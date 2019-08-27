using AutoMapper;
using QuestRooms.BLL.DTOModels;
using QuestRooms.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<City, CityDto>();
            CreateMap<Address, AddressDto>();
            CreateMap<Company, CompanyDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Image, ImageDto>();
            CreateMap<Street, StreetDto>();
            CreateMap<Room, RoomDto>();

        }

    }
}
