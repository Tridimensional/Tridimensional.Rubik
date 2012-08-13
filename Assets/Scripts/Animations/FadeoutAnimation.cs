﻿using Tridimensional.Rubik.Core;
using Tridimensional.Rubik.Core.Enums;
using UnityEngine;

public class FadeoutAnimation : MonoBehaviour
{
    public float Duration = 3;
    public Level NextLevel { get; set; }

    public bool Finished { get { return _percentage >= 1; } }

    float _percentage = 0;
    Texture2D _solidColor;

    void Awake()
    {
        _solidColor = new Texture2D(1, 1);
        _solidColor.SetPixel(0, 0, GlobalConfiguration.BackgroundColor);
        _solidColor.Apply();
    }

    void OnGUI()
    {
        if (Finished) { Application.LoadLevel(NextLevel.ToString()); }

        _percentage += Time.deltaTime / Duration;

        GUI.color = new Color(1, 1, 1, Mathf.Pow(_percentage, 3f));
        GUI.depth = -1;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _solidColor);
    }
}
