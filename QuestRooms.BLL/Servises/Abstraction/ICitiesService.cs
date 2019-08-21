using QuestRooms.BLL.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Servises.Abstraction
{
    public interface ICitiesService
    {
        ICollection<CityDto> GetCities();
    }
}
