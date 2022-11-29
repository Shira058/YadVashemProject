using DTO;
using Yad_Vashem.Entities;

namespace Yad_Vashem.Service.Interfaces;
public interface ITestimonyService
{
    public Task<TestimonyDTO> getTestimonyInfo();
    public Task<Resource> getTestimonyResourceByType(ResourceType type);

}
