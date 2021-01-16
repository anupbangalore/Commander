using AutoMapper;
using Commander.Models;
using Commander.Dtos;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source -> Target meaning <internal data is mapped to external> 
            CreateMap<Command,CommandReadDto>();

            // Target -> Source meaning <external data is mapper to internal data model>
            CreateMap<CommandCreateDto, Command>();

            CreateMap<CommandUpdateDto, Command>(); 

            CreateMap<Command, CommandUpdateDto>();
        }
    }
}