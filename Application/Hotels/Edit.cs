using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Hotels
{
    public class Edit
    {
        public class Command : IRequest
        {
            internal object hotel;

            public Hotel Hotel { get; set; }
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

                var hotel = await _context.Hotels.FirstOrDefaultAsync(a => a.Id == request.Id);

                //_mapper.Map(request.Activity, activity);
                hotel.City = request.Hotel.City;
                hotel.Address = request.Hotel.Address;
                hotel.ReceptionPhoneNumber = request.Hotel.ReceptionPhoneNumber;
                hotel.ManagerPhoneNumber = request.Hotel.ManagerPhoneNumber;
                hotel.ManagerFirstName = request.Hotel.ManagerFirstName;
                hotel.CompanyName = request.Hotel.CompanyName;
                hotel.Country = request.Hotel.Country;
                hotel.ZipCode = request.Hotel.ZipCode;
                hotel.ManagerEmail = request.Hotel.ManagerEmail;
                hotel.ManagerLastName = request.Hotel.ManagerLastName;
                hotel.ManagerFirstName = request.Hotel.ManagerFirstName;
                hotel.ReceptionEmail = request.Hotel.ReceptionEmail;
                hotel.SalesDepartmentEmail = request.Hotel.SalesDepartmentEmail;
                hotel.SalesDepartmentPhoneNumber = request.Hotel.SalesDepartmentPhoneNumber;
                


                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}