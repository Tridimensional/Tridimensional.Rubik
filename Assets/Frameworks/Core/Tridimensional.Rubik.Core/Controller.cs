using Tridimensional.Rubik.Core;
using Tridimensional.Rubik.Core.Enums;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public bool Fadein;
    public bool Fadeout;

    bool _added;

    void Awake()
    {
        if (Fadein)
        {
            gameObject.AddComponent<FadeinAnimation>();
        }

        SendMessage("Init");
    }

    protected void LoadLevel(Level level)
    {
        if (!_added && Fadeout)
        {
            var fadeoutAnimation = gameObject.AddComponent<FadeoutAnimation>();
            fadeoutAnimation.NextLevel = level;

            _added = true;
        }
    }
}
