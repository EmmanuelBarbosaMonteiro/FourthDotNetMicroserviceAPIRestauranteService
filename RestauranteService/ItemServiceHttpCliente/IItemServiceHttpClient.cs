using RestauranteService.Dtos;

namespace RestauranteService.ItemServiceHttpCliente
{
    public interface IItemServiceHttpClient
    {
        public void EnviaRestauranteParaItemService(RestauranteReadDto readDto);
    }
}
