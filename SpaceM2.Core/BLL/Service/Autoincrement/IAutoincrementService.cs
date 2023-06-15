using System.Threading.Tasks;

namespace SpaceM2.Core.BLL.Service
{
    public interface IAutoincrementService
    {
        AutoincrementModel GetAutoincrementNumber(string firstColumName, string secondColumName, string tableName);
    }
}