using SpaceM2.Core.BLL.Model;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace SpaceM2.Core.BLL.Service
{
    public interface IQuantityRepository
    {
        Task<IEnumerable<QuantityModel>> GetAll();
    }
}