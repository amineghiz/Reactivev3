using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Drinks
{
    public class Create
    {
        public class Command : IRequest<Drink>
        {
            public Drink Drink { get; set; }
        }
        public class Handler : IRequestHandler<Command, Drink>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Drink> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Drinks.AddRange(request.Drink);

                await _context.SaveChangesAsync(cancellationToken);
                return request.Drink;
            }
        }
    }
}