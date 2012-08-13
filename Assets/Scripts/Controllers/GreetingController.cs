using Tridimensional.Rubik.Core;
using Tridimensional.Rubik.Core.Enums;
using UnityEngine;

public class GreetingController : Controller
{
    float _duration = 2f;
    Rect _logoTextureRect;
    Texture2D _logoTexture;

    void Awake()
    {
        InitializeScene();

        _logoTexture = Resources.Load("Images/Logos/256") as Texture2D;
        _logoTextureRect = GetCompatibleLogoRect();
    }

    void OnGUI()
    {
        GUI.DrawTexture(_logoTextureRect, _logoTexture);

        if (Time.time > _duration)
        {
            LoadLevel(Level.Crossing);
        }
    }

    Rect GetCompatibleLogoRect()
    {
        var height = Screen.height * 0.4f;
        var width = height * _logoTexture.width / _logoTexture.height;
        return new Rect((Screen.width - width) * 0.5f, (Screen.height - height) * 0.5f, width, height);
    }
}
