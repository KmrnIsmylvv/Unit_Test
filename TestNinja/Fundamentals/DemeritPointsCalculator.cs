using System.Net.Http.Headers;

namespace TestNinja.Fundamentals;

public class DemeritPointsCalculator
{
    private const int SpeedLimit = 65;

    public int CalculateDemeritPoints(int speed)
    {
        if (speed < 0)
            throw new ArgumentOutOfRangeException();

        if (speed <= SpeedLimit) return 0;

        const int kmPerDemeritPoint = 5;
        var demeritPoints = (speed - SpeedLimit) / kmPerDemeritPoint;

        return demeritPoints;
    }
}