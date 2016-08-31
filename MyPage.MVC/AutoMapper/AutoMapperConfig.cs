using AutoMapper;

namespace MyPage.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMapProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
            
        }
    }
}