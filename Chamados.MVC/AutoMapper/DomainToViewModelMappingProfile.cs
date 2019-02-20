using AutoMapper;
using Chamados.Domain.Entities;
using Chamados.MVC.ViewModel;

namespace Chamados.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ChamadoViewModel, Chamado>();
        }
    }
}