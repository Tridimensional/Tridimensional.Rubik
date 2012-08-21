using Tridimensional.Rubik.Core;
using Tridimensional.Rubik.Service.IServiceProvider;
using Tridimensional.Rubik.Service.ServiceImplementation;

public class CrossingController : Controller
{
    ICrossingService _crossingService;

    void Awake()
    {
        _crossingService = CrossingService.Instance;

        RegisterComponents();
    }

    void Update()
    {

    }
}
