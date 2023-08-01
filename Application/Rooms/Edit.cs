using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Rooms
{
    public class Edit
    {
        public class Command : IRequest
        {
            internal object room;

            public Room Room { get; set; }
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            //private readonly IMapper _mapper;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {

                var room = await _context.Rooms.FirstOrDefaultAsync(a => a.Id == request.Id);

                //_mapper.Map(request.Activity, activity);
                room.Denomination = request.Room.Denomination;
                room.BedNumber = request.Room.BedNumber;
                room.MaxAdultsOccupation = request.Room.MaxAdultsOccupation;
                room.MaxKidsOccupation = request.Room.MaxKidsOccupation;
                room.TotalRoomNumber = request.Room.TotalRoomNumber;
                room.Description = request.Room.Description;
                room.PMSIntegration = request.Room.PMSIntegration;
               


                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}