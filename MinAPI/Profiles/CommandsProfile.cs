using AutoMapper;
using MinAPI.Dtos;
using MinAPI.Models;

namespace MinAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // source -> target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}