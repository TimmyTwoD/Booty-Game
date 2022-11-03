using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HighlightEffect : MonoBehaviour
{
    /// <summary>
    /// Called every update when the effect is enabled and active.
    /// </summary>
    public virtual void OnActive() { }

    /// <summary>
    /// Called when the effect is enabled and has been activated.
    /// </summary>
    public virtual void OnActivate() { }
    
    /// <summary>
    /// Called when the effect has been deactivated.
    /// </summary>
    public virtual void OnDeactivate() { }
}
