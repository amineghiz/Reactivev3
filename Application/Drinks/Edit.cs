using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Drinks
{
    public class Edit
    {
        public class Command : IRequest
        {
            internal object drink;

            public Drink Drink { get; set; }
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

                var drink = await _context.Drinks.FirstOrDefaultAsync(a => a.Id == request.Id);

                //_mapper.Map(request.Activity, activity);
                drink.Title = request.Drink.Title;
                drink.Description = request.Drink.Description;
                drink.PricePerPerson = request.Drink.PricePerPerson;
                drink.VTA = request.Drink.VTA;
                

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}