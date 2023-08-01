using Domain;
using MediatR;
using Persistence;

namespace Application.Halls
{
    public class Details
    {
        public class Query : IRequest<Hall>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Hall>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Hall> Handle(Query request, CancellationToken cancellationToken)
            {
               
                   return await _context.Halls.FindAsync(request.Id);
                
            }
        }
    }
}