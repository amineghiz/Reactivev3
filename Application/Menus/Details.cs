using Domain;
using MediatR;
using Persistence;

namespace Application.Menus

{
    public class Details
    {
        public class Query : IRequest<Menu>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Menu>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Menu> Handle(Query request, CancellationToken cancellationToken)
            {
               
                   return await _context.Menus.FindAsync(request.Id);
                
            }
        }
    }
}