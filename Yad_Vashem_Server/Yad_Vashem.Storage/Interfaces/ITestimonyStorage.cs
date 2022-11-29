using Yad_Vashem.Entities;

namespace Yad_Vashem.Service.Interfaces;
public interface ITestimonyStorage
{
    public Task<Testimony> getTestimonyInfo();
    public Task<Resource> getTestimonyResourceByType(ResourceType type);

}
