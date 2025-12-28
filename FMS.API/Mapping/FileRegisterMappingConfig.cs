using FMS.API.DTOs;
using FMS.API.Entities;
using Mapster;

namespace FMS.API.Mapping;

public class FileRegisterMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        //TODO add url for Url property in FileObjectDto
        config.NewConfig<FileObject, FileObjectDto>();
        config.NewConfig<FileObjectDto, FileObject>();
    }
}