using Refit;

namespace ComponentLibraryDemo
{
    [Headers("Content-Type: application/json")]
    public interface IValuesClient
    {
        [Get("/Values")] Task<List<ValueViewModel>> Get();
        [Get("/Values/{id}")] Task<ValueViewModel> Get(int id);
        [Post("/Values")] Task Post([Body] ValueViewModel value);
        [Put("/Values/{id}")] Task Put([Body] ValueViewModel value, int id);
        [Delete("/Values/{id}")] Task Delete(int id);
    }
}
