using Demo.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        [HttpGet]
        [Route("getPlaces")]

        public IActionResult getPlace() 
        {
            List<Place> _placeList = new List<Place>();

            Place p = null;

            p = new Place
            {
                Name = "Atteridgeville",
                Adress = "165 Khudu Street",
                Vicinity = "Sasol Garage",
                Url = "http://www.example.com",
                Longitude = "-25.767720",
                Latitude = "28.078320",
                Utc = "+2:00"
            };
            _placeList.Add(p);

             p = new Place
             {
                 Name = "Saulsville",
                 Adress = "9 Maunde Street",
                 Vicinity = "Unjani Clinic",
                 Url = "http://www.example.com",
                 Longitude = "-45.767750",
                 Latitude = "68.078340",
                 Utc = "+2:00"
             };
            _placeList.Add(p);

            p = new Place
             {
                 Name = "Northriding",
                 Adress = "14 Dexter Road",
                 Vicinity = "North World Complex",
                 Url = "http://www.example.com",
                 Longitude = "-15.967720",
                 Latitude = "19.908320",
                 Utc = "+2:00"
             };
            _placeList.Add(p);
            return Ok(_placeList);
        }
    }
}
