using Tridimensional.Rubik.Core;
using Tridimensional.Rubik.Core.Enums;
using Tridimensional.Rubik.Service.IServiceProvider;
using Tridimensional.Rubik.Service.ServiceImplementation;
using UnityEngine;

public class CrossingController : Controller
{
    ICrossingService _crossingService;

    void Init()
    {
        _crossingService = CrossingService.Instance;

        Camera.mainCamera.backgroundColor = GlobalConfiguration.BackgroundColor;
    }

    void Update()
    {
        if (Time.time > 6)
        {
            LoadLevel(Level.Battle);
        }
    }
}
