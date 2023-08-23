﻿using AutoMapper;
using Church.DTO;
using Church.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Church.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Request, RequestDTO>();
            CreateMap<RequestDTO, Request>();

            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Role, opt => opt.Ignore());
            CreateMap<UserDTO, User>();

            CreateMap<UpdateUserDTO, User>();

            CreateMap<Visitor, VisitorDTO>();
            CreateMap<VisitorDTO, Visitor>();

            CreateMap<Announcement, AnnouncementDTO>();
            CreateMap<AnnouncementDTO, Announcement>();
        }
    }
}
