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
    public class CitiesService : ICitiesService
    {
        private readonly IGenericRepository<City> repository;
        private readonly IMapper mapper;

        public CitiesService(IGenericRepository<City> _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }

        public ICollection<CityDto> GetCities()
        {
            var cities = repository.GetAll();
            return mapper.Map<IEnumerable<City>, ICollection<CityDto>>(cities);
        }
    }
}
