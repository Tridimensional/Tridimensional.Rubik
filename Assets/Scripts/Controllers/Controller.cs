using Tridimensional.Rubik.Core;
using Tridimensional.Rubik.Core.Enums;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public bool Fadein;
    public bool Fadeout;

    protected void RegisterComponents()
    {
        if (Fadein)
        {
            gameObject.AddComponent<FadeinAnimation>();
        }
    }

    protected void LoadLevel(Level level)
    {
        if (Fadeout && gameObject.GetComponent<FadeoutAnimation>() == null)
        {
            var fadeoutAnimation = gameObject.AddComponent<FadeoutAnimation>();
            fadeoutAnimation.NextLevel = level;
        }
    }
}
