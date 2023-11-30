using AutoMapper;
using BusinessLogicL.DTOs;
using DataAL.EF.Models;
using DataAL.PersonRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicL.Services
{
    public class PersonService
    {
        public static List<PersonDTO> GetAll()
        {
            var data = PersonRepo.GetAllPerson();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Person,PersonDTO>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<List<PersonDTO>>(data);

            return ret;
        }
    }
}
