using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DesafioBahia.Domain.Models;
using DesafioBahia.Resources;

namespace DesafioBahia.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveOrdemResource, Ordem>();
        }
    }
}
