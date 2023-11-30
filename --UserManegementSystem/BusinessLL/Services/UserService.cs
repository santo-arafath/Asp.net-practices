using AutoMapper;
using BusinessLL.DTOs;
using DataAccessL.EF.Models;
using DataAccessL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLL.Services
{
    public class UserService
    {
        public static List<UserDTO> getAll()
        {
            var data = UserRepo.getAll();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<List<UserDTO>>(data);
            return ret;
        }



        public static UserDTO getUserById(int id)
        {
            var data = UserRepo.getUserById(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<UserDTO>(data);
            return ret;
        }


        public static string CreateUser(UserDTO udt)
        {
            
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(config);
            var ent = mapper.Map<User>(udt);

            var msg = UserRepo.CreateUser(ent);

            return msg;
            

            
        }



        public static string DeleteUser(int id)
        {
            var msg = UserRepo.DeleteUser(id);

         
            return msg;



        }


        




        public static string UpdateUser(UserDTO udt,int id)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(config);
            var ent = mapper.Map<User>(udt);

            var msg = UserRepo.UpdateUser(ent,id);

            return msg;



        }
    }
}
