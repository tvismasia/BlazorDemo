using Demo.DataModels;

namespace WebDemoUI.Services
{
    public class PlaceService : IPlaceService
    {
        //iporting my HttpClient
        private readonly HttpClient httpClient;

        //Injection
        public PlaceService(HttpClient httpClient) 
        {
            this.httpClient = httpClient;
        }
        //implementing the interface
        public async Task<IEnumerable<Place>> getPlaces()
        {
            return await httpClient.GetFromJsonAsync<Place[]>("api/Place/getPlaces");
            
        }
    }
}
