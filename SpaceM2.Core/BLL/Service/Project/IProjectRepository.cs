using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using SpaceM2.Core.BLL.Model;

namespace SpaceM2.Core.BLL.Service
{
    public interface IProjectRepository
    {
        IEnumerable<ProjectModel> GetAll();
        ProjectModel GetById(int id);
        Task<int> Add(ProjectModel project);
        Task<int> Modify(ProjectModel project, int id);
        Task<int> Remove(int id);
    }
}