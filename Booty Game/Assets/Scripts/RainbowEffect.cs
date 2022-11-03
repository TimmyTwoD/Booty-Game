using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowEffect : HighlightEffect
{
    private Renderer _rend;

    void Start()
    {
        _rend = GetComponent<Renderer>();
    }

    public override void OnActive()
    {
        float t = Time.time;
        float r = Mathf.Sin(t);
        float g = Mathf.Sin(0.5f * t);
        float b = Mathf.Sin(0.25f * t);

        _rend.material.color = new Color(r, g, b);
    }

    public override void OnDeactivate()
    {
        _rend.material.color = Color.white;
    }
}
