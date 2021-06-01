using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    private PlayerManager playerManager;
    private CameraManager cameraManager;
    private ClientManager clientManager;
    private AudioManager audioManager;
    private RequestManager requestManager;

    private void Awake() {
        if(instance == null) instance = this;
        InitializeManagers();
        

    }
    


    void InitializeManagers(){
        playerManager = new PlayerManager(this);
        cameraManager = new CameraManager(this);
        clientManager = new ClientManager(this);
        audioManager = new AudioManager(this);
        requestManager = new RequestManager(this);

        playerManager.OnInit();
        cameraManager.OnInit();
        clientManager.OnInit();
        audioManager.OnInit();
        requestManager.OnInit();
    }

    private void Update() {
        playerManager.Update();
        cameraManager.Update();
        clientManager.Update();
        audioManager.Update();
        requestManager.Update();
    }

    public void AddRequest(ActionCode actionCode, BaseRequest request){
        requestManager.AddRequest(actionCode,request);
    }
    public void SendRequest(RequestCode requestCode, ActionCode actionCode, string data)
    {
        clientManager.SendRequest(requestCode,actionCode,data);
    }
    public void HandleResponse(ActionCode actionCode, string data)
    {
        requestManager.HandleResponse(actionCode,data);
    }
}
