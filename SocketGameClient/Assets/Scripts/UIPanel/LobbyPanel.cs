using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyPanel : BasePanel
{
    [SerializeField] CreateRoomRequest createRoomRequest;
    [SerializeField] JoinRoomRequest joinRoomRequest;
    public override void Awake()
    {
        panelType = UIPanelType.LobbyPanel;
        base.Awake();
    }
    public void OnCreateRoomButtonClicked()
    {
        createRoomRequest.CreateRoom();
    }
    public void OnJoinRoomClicked()
    {
        //TODO random odaya atacaksın
    }
}
