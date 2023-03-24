using AutoMapper;

namespace Pokemon.AutoMapper;

public class PokemonDomainToViewModel : Profile
{
    public PokemonDomainToViewModel()
    {
        CreateMap<MakeOrderModel, CreateOrderCommand>()
            .ConstructUsing(c => new CreateOrderCommand(c.UserId, c.ProductId, c.Quantity));
    }
}