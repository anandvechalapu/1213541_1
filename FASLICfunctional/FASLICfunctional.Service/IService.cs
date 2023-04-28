FASLICfunctional.Service

using FASLICfunctional.DTO;

namespace FASLICfunctional.Service
{
    public interface IService
    {
        List<ClientDTO> GetClients();
        List<ProductDTO> GetProducts();
    }
}