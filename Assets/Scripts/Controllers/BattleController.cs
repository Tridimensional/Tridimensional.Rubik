using Tridimensional.Rubik.Core;
using Tridimensional.Rubik.Service.IServiceProvider;
using Tridimensional.Rubik.Service.ServiceImplementation;
using UnityEngine;

public class BattleController : Controller
{
    GameObject _rubik;
    IBattleService _battleService;

    void Init()
    {
        _battleService = BattleService.Instance;
        _rubik = GameObject.Find("3X RUBIK");

        Camera.mainCamera.backgroundColor = GlobalConfiguration.BackgroundColor;
    }

    void Update()
    {
        _rubik.transform.Rotate(Time.deltaTime * 20, Time.deltaTime * 30, Time.deltaTime * 0);

        var fingerCount = 0;

        foreach (var touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;
            }
        }

        switch (fingerCount)
        {
            case 1:
                break;
            case 2:
                break;
            default:
                break;
        }
    }
}
