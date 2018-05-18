using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidily.DTOs;
using Vidily.Models;

namespace Vidily.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            //customer map profiles
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();

            //Moive Map Profile
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
          


        }
    }
}