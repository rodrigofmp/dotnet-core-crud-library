using AutoMapper;
using LibraryAPI.Core.Entities;
using LibraryAPI.Models.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Models.Mappers
{
    public class ResourceToDomainMappingProfile : Profile
    {
        public ResourceToDomainMappingProfile()
        {
            CreateMap<SaveBookResource, Book>();
        }
    }
}
