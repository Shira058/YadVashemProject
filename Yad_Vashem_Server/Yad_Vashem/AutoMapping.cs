using AutoMapper;
using DTO;
using Yad_Vashem.Entities;

namespace Yad_Vashem;
class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<Testimony, TestimonyDTO>()
       .ForMember(des => des.Title, opts => opts.MapFrom(src => src.Title))
       .ForMember(des => des.Tag, opts => opts.MapFrom(src => src.Tag))
       .ForMember(des => des.URL, opts => opts.MapFrom(src => src.URL))
       .ForMember(des => des.InfoText, opts => opts.MapFrom(src => src.InfoText))
       .ReverseMap();
    }
}
