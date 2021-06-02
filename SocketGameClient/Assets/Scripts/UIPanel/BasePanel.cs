using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePanel : MonoBehaviour
{
    protected GameController controller;
    
    protected UIPanelType panelType = UIPanelType.None;

    public virtual void Awake() {
        controller = GameController.instance;
    }
  
}
