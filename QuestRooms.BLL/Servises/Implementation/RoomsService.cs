using AutoMapper;
using QuestRooms.BLL.DTOModels;
using QuestRooms.BLL.Servises.Abstraction;
using QuestRooms.DAL.Entities;
using QuestRooms.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Servises.Implementation
{
    public class RoomsService : IRoomsService
    {
        private readonly IGenericRepository<Room> repository;
        private readonly IMapper mapper;

        public RoomsService(IGenericRepository<Room> _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }

        public ICollection<RoomDto> GetRooms()
        {
            var rooms = repository.GetAll().ToList();
            return mapper.Map<IEnumerable<Room>, ICollection<RoomDto>>(rooms);
        }

        public ICollection<RoomDto> GetRoomsbyCity(int id)
        {
            var rooms = repository.GetAll().ToList();
            var r_list = rooms.Where(r => r.Address.City.ID == id).ToList();
            return mapper.Map<List<Room>, ICollection<RoomDto>>(r_list);
        }
    }
}
