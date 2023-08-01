using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Drinks
{
    public class List
    {
        public class Query : IRequest<List<Drink>>
        {
        }

        public class Handler : IRequestHandler<Query, List<Drink>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Drink>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Drinks.ToListAsync();
            }
        }
    }
}