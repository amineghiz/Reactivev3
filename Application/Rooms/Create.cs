using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.Rooms
{
    public class Create
    {
        public class Command : IRequest<Room>
        {
            public Room Room { get; set; }
        }
        public class Handler : IRequestHandler<Command, Room>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Room> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Rooms.AddRange(request.Room);

                await _context.SaveChangesAsync(cancellationToken);
                return request.Room;
            }
        }
    }
}