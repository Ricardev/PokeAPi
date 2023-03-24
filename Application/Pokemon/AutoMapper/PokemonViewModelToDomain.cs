using AutoMapper;

namespace Pokemon.AutoMapper;

public class ViewModelToDatabase : Profile
{
    public ViewModelToDomain()
    {
        CreateMap<MakeOrderModel, CreateOrderCommand>()
            .ConstructUsing(c => new CreateOrderCommand(c.UserId, c.ProductId, c.Quantity));
    }
}