using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.Interface
{
    public interface IEarthquake
    {
        Task<EarthquakeInfo> GetEarthquakeInfoAsync();
    }
}
