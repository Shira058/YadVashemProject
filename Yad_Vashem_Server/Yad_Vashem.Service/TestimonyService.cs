using AutoMapper;
using DTO;
using Yad_Vashem.Service.Interfaces;
using Yad_Vashem.Entities;

namespace Yad_Vashem.Service;
public class TestimonyService: ITestimonyService
{
    private ITestimonyStorage _testimonyStorage;
    private IMapper _IMapper;
    public TestimonyService(ITestimonyStorage testimonyStorage, IMapper Mapper)
    {
        _testimonyStorage=testimonyStorage;
        _IMapper=Mapper;
    }
    public async Task<TestimonyDTO> getTestimonyInfo()
    {
        var testimonyInfo =  await _testimonyStorage.getTestimonyInfo();
        return _IMapper.Map<Testimony , TestimonyDTO> (testimonyInfo);
    }
    public async Task<Resource> getTestimonyResourceByType(ResourceType type)
    {
        return await _testimonyStorage.getTestimonyResourceByType(type);      
    }
}