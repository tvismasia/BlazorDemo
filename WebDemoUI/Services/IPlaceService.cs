using Demo.DataModels;

namespace WebDemoUI.Services
{
    public interface IPlaceService 
    {
         //method to return getPlaces

        Task<IEnumerable<Place>> getPlaces();
    }
}
