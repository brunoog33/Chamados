
using AutoMapper;
using Chamados.Domain.Entities;
using Chamados.MVC.ViewModel;

namespace Chamados.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ChamadoViewModel, Chamado>();
        }
    }
}