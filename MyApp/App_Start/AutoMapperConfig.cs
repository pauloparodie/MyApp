using System.Web;
using System.Web.Optimization;
using System;
using AutoMapper;
using MyApp.DomainModel.Entities;
using MyApp.ViewModel;
using MyApp.ViewModel.Identity;
using MyApp.IdentityProvider.Model;


namespace MyApp
{
    public class AutoMapperHelper
    {

        public static void ConfigureMappings()
        {
            // Initialize AutoMapper
            try
            {
                Mapper.CreateMap<Pessoa, PessoaViewModel>();
                Mapper.CreateMap<PessoaViewModel, Pessoa>();

                Mapper.CreateMap<Animal, AnimalViewModel>();
                Mapper.CreateMap<AnimalViewModel, Animal>();

                Mapper.CreateMap<RegisterViewModel, ApplicationUser>().ForMember(dest => dest.PasswordHash, opt => opt.MapFrom<string>(source => source.Password));
            }
            catch (Exception ex)
            {
                throw new Exception("Error initializing AutoMapper->" + ex.Message);
            }
        }

        public static Object MapStatic(Object source, Type destinationType)
        {
            if (source == null)
                return null;
            else
                return Mapper.Map(source, source.GetType(), destinationType);
        }
    }
}
