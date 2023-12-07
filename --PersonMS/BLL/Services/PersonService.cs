using AutoMapper;
using BLL.DTOs;
using DLL;
using DLL.EF.Models;
using DLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Services
{
    public class PersonService
    {
        public static List<PersonDTO> GetAll()
        {
            var data = DataAccessFactory.PersonData().Get();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Person, PersonDTO>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<List<PersonDTO>>(data);
            return ret;
        }

        public static string Create(PersonDTO ps)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<PersonDTO, Person>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Person>(ps);

            var ret  = DataAccessFactory.PersonData().Create(data);

            return ret ;
        }
    }
}
