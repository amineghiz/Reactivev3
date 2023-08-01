using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Menus
{
    public class Edit
    {
        public class Command : IRequest
        {
            internal object menu;

            public Menu Menu { get; set; }
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

                var menu = await _context.Menus.FirstOrDefaultAsync(a => a.Id == request.Id);

                //_mapper.Map(request.Activity, activity);
                menu.Title = request.Menu.Title;
                menu.Description = request.Menu.Description;
                menu.PricePerPerson = request.Menu.PricePerPerson;
                menu.VAT = request.Menu.VAT;
                

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}