using Domain;
using MediatR;
using Persistence;

namespace Application.Hotels
{
    public class Details
    {
        public class Query : IRequest<Hotel>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Hotel>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Hotel> Handle(Query request, CancellationToken cancellationToken)
            {
               
                   return await _context.Hotels.FindAsync(request.Id);
                
            }
        }
    }
}