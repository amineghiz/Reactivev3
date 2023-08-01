using Domain;
using MediatR;
using Persistence;

namespace Application.Drinks

{
    public class Details
    {
        public class Query : IRequest<Drink>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Drink>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Drink> Handle(Query request, CancellationToken cancellationToken)
            {
               
                   return await _context.Drinks.FindAsync(request.Id);
                
            }
        }
    }
}