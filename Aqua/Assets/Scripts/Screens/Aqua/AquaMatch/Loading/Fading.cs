﻿using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour
{
    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.5f;

    private int drawDept = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1;

    public void Start()
    {
        BeginFade(-1);
    }

    public void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDept;
        GUI.DrawTexture(new Rect(0, 0, Screen.height, Screen.width), fadeOutTexture);
    }

    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed);
    }
}
