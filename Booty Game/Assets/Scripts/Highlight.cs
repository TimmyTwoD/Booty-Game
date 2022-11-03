using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public enum HightlightMode
    {
        Hover,
        EarlyToggle,
        LateToggle,
        Pressed
    }

    public enum HighlightState
    {
        Disabled,
        Enabled,
        Active
    }

    public HightlightMode mode;
    public HighlightState state = HighlightState.Enabled;
    public HighlightEffect effect;

    private HighlightState _lastState = HighlightState.Disabled;

    void Update()
    {
        switch (state)
        {
            case HighlightState.Active:
                effect.OnActive();
                break;
            case HighlightState.Enabled:
            case HighlightState.Disabled:
                Deactivate();
                break;
        }

        _lastState = state;
    }

    void OnMouseEnter()
    {
        if (mode == HightlightMode.Hover)
        {
            Activate();
        }
    }

    void OnMouseExit()
    {
        if (mode == HightlightMode.Hover)
        {
            Deactivate();
        }
        
        if (mode == HightlightMode.Pressed)
        {
            Deactivate();
        }
    }

    void OnMouseDown()
    {
        if (mode == HightlightMode.Pressed)
        {
            Activate();
        }
        
        if (mode == HightlightMode.EarlyToggle)
        {
            Toggle();
        }
    }

    void OnMouseUp()
    {
        if (mode == HightlightMode.Pressed)
        {
            Deactivate();
        }
    }

    void OnMouseUpAsButton()
    {
        if (mode == HightlightMode.LateToggle)
        {
            Toggle();
        }
    }

    void Activate()
    {
        if (state == HighlightState.Enabled)
        {
            state = HighlightState.Active;
            effect.OnActivate();
        }
    }

    void Deactivate()
    {
        if (state == HighlightState.Active)
        {
            state = HighlightState.Enabled;
            effect.OnDeactivate();
        }
        else if (_lastState == HighlightState.Active)
        {
            effect.OnDeactivate();
        }
    }

    void Toggle()
    {
        if (state == HighlightState.Active)
            Deactivate();
        else
            Activate();
    }
}
