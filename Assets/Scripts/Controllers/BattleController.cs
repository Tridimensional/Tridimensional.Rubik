using Tridimensional.Rubik.Service.IServiceProvider;
using Tridimensional.Rubik.Service.ServiceImplementation;

public class BattleController : Controller
{
    IBattleService _battleService;

    void Awake()
    {
        _battleService = BattleService.Instance;

        RegisterComponents();
    }
}
