using AutoMapper;
using CL3_TristanVelaPieroAlessandro.DataAccess;
using CL3_TristanVelaPieroAlessandro.Modelo;

namespace CL3_TristanVelaPieroAlessandro.MapperProfiles
{
    public class DocenteProfile : Profile
    {
        public DocenteProfile()
        {
            CreateMap<DocenteEntity, DocenteModel>()
    .ForMember(dest => dest.Codigo, act => act.MapFrom(src => src.Id))
    .ForMember(dest => dest.Nombres, act => act.MapFrom(src => src.Nombres))
    .ForMember(dest => dest.Apellidos, act => act.MapFrom(src => src.Apellidos))
    .ForMember(dest => dest.DNI, act => act.MapFrom(src => src.DNI))
    .ForMember(dest => dest.FechaNacimiento, act => act.MapFrom(src => src.FechaNacimiento))
    .ForMember(dest => dest.GradoAcademico, act => act.MapFrom(src => src.GradoAcademico))
    .ForMember(dest => dest.CentroEstudios, act => act.MapFrom(src => src.CentroEstudios))
    .ForMember(dest => dest.AñosExperiencia, act => act.MapFrom(src => src.AñosExperiencia))
    .ForMember(dest => dest.AñosDocencia, act => act.MapFrom(src => src.AñosDocencia))
    .ReverseMap();
        }
    }
}
