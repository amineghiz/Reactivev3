using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Hotels
{
    public class List
    {
        public class Query : IRequest<List<Hotel>>
        {
        }

        public class Handler : IRequestHandler<Query, List<Hotel>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Hotel>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Hotels.ToListAsync();
            }
        }
    }
}