using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomPanel : BasePanel
{
    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject readyButton;

    public override void Awake()
    {
        base.Awake();
        SetRoomButtons(controller.playerManager.IsHouseOwner);
    }

    private void SetRoomButtons(bool isOwner)
    {
        startButton.gameObject.SetActive(isOwner);
        readyButton.gameObject.SetActive(!isOwner);
    }
}
