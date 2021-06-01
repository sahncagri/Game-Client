using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

public class BaseRequest : MonoBehaviour
{
    protected GameController gamecontroller;
    protected RequestCode requestCode = RequestCode.None;
    protected ActionCode actionCode = ActionCode.None;
    
    public virtual void Awake()
    {
        GameController.instance.AddRequest(actionCode,this);
        gamecontroller = GameController.instance;
    }
    public virtual void SendRequest(string data)
    {
        gamecontroller.SendRequest(requestCode,actionCode,data);
    }
    public virtual void OnResponse(string data){

    }
}
