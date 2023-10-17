using TripService.Exception;

namespace TripService.Trip;

public class TripRepository
{
    public static List<Trip> FindTripsByUser(User.User user)
    {
        throw new DependendClassCallDuringUnitTestException(
            "TripRepository should not be invoked on an unit test.");
    }
}