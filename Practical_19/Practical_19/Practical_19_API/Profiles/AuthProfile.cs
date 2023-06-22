using AutoMapper;
using Practical_19_API.Models;

namespace Practical_19_API.Profiles
{
    public class AuthProfile: Profile
    {
        public AuthProfile()
        {
            CreateMap<RegisterDto, User>();
            CreateMap<LoginDto, User>();
        }
    }
}
