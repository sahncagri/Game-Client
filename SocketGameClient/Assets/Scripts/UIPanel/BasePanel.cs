using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePanel : MonoBehaviour
{
    protected GameController controller;
    public GameController Controller{
        get{return controller;}
    }

    public virtual void Awake() {
        controller = GameController.instance;
    }
   
}
