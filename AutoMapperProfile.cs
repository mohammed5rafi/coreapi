using System.Linq;
using AutoMapper;
using Webapi.Models;
using Webapi.Models.DTO.Charecter;
using Webapi.Models.DTO.Fight;
using Webapi.Models.DTO.Skill;
using Webapi.Models.DTO.Weapon;

namespace Webapi
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Charecter,GetCharecterDTO>()
            .ForMember(Dto => Dto.Skills,c=> c.MapFrom(c=> c.CharecterSkills.Select(cs=>cs.Skill)));
            CreateMap<AddCharecterDTO,Charecter>();
            CreateMap<Weapon,GetWeaponDTO>();
            CreateMap<Skill , GetSkillDTO>();
            CreateMap<Charecter,HighscoreDTO>();
        }
    }
}