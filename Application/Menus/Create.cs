using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Menus
{
    public class Create
    {
        public class Command : IRequest<Menu>
        {
            public Menu Menu { get; set; }
        }
        public class Handler : IRequestHandler<Command, Menu>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Menu> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Menus.AddRange(request.Menu);

                await _context.SaveChangesAsync(cancellationToken);
                return request.Menu;
            }
        }
    }
}