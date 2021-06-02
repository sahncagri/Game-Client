using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestManager : BaseManager
{
    private Dictionary<ActionCode,BaseRequest> requestDictionary= new Dictionary<ActionCode, BaseRequest>() ;
    public RequestManager(GameController controller) : base(controller){}

    public override void OnInit()
    {
        base.OnInit();
    }

    public void HandleResponse(ActionCode actionCode, string data)
    {
        BaseRequest baseRequest;
        requestDictionary.TryGetValue(actionCode,out baseRequest);
        baseRequest.OnResponse(data);
    }
    public void AddRequest(ActionCode actionCode, BaseRequest request){
        requestDictionary.Add(actionCode,request);
    }
}
