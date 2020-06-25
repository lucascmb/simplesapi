using AutoMapper;
using DesafioBahia.Domain.Models;
using DesafioBahia.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Ordem, OrdemResource>();
        }
    }
}
