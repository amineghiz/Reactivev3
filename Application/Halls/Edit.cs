using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Halls
{
    public class Edit
    {
        public class Command : IRequest
        {
            internal object hall;

            public Hall Hall { get; set; }
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

                var hall = await _context.Halls.FirstOrDefaultAsync(a => a.Id == request.Id);

                //_mapper.Map(request.Activity, activity);
                hall.Description = request.Hall.Description;
                hall.NoHalfDay = request.Hall.NoHalfDay;
                hall.Cabaret = request.Hall.Cabaret;
                hall.Banquet = request.Hall.Banquet;
                hall.Conference = request.Hall.Conference;
                hall.Reunion = request.Hall.Reunion;
                hall.Cocktail= request.Hall.Cocktail;
                hall.DayLight = request.Hall.DayLight;
                //hall.Equipements = request.Hall.Equipements;
                hall.Name = request.Hall.Name;
                hall.PriceHalfDay = request.Hall.PriceHalfDay;
                hall.PricePerDay = request.Hall.PricePerDay;
                hall.SchoolRank = request.Hall.SchoolRank;
                hall.Showroom = request.Hall.Showroom;
                hall.Surface = request.Hall.Surface;
                hall.TableInU = request.Hall.TableInU;
                hall.vide = request.Hall.vide;
               


                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}