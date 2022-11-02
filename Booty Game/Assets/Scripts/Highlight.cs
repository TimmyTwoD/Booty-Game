using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public enum HightlightMode
    {
        Hover,
        Toggle,
        Pressed
    }

    public bool isEnabled = true;

    [SerializeField]
    private HightlightMode _mode;
    
    private bool _isActive;
    private Renderer _rend;

    // Start is called before the first frame update
    void Start()
    {
        _rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnabled && _isActive)
        {
            float t = Time.time;
            float r = Mathf.Sin(t);
            float g = Mathf.Sin(0.5f * t);
            float b = Mathf.Sin(0.25f * t);
            
            _rend.material.color = new Color(r, g, b);
        }
        else
        {
            _rend.material.color = Color.white;
        }
    }

    void OnMouseEnter()
    {
        if (_mode == HightlightMode.Hover)
            _isActive = true;
    }

    void OnMouseExit()
    {
        if (_mode == HightlightMode.Hover)
            _isActive = false;
        
        if (_mode == HightlightMode.Pressed)
            _isActive = false;
    }

    void OnMouseDown()
    {
        if (_mode == HightlightMode.Pressed)
            _isActive = true;
        
        if (_mode == HightlightMode.Toggle)
            _isActive = !_isActive;
    }

    void OnMouseUp()
    {
        if (_mode == HightlightMode.Pressed)
            _isActive = false;
    }
}
