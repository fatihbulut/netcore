using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public interface IWorldRepository 
    {
        IEnumerable<Trip> GetAllTrips();
        Trip GetTripByName(string tripName);
        IEnumerable<Trip> GetTripsByUsername(string name);
        Trip GetUserTripByName(string tripName, string username);

        void AddTrip(Trip trip);
        void AddStop(string tripName, Stop newStop, string username);


        Task<bool> SaveChangesAsync();
        
    }
}