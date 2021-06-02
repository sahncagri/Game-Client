
using UnityEngine;

public class CreateRoomRequest : BaseRequest
{
    public override void Awake()
    {
        requestCode = RequestCode.Room;
        actionCode = ActionCode.CreateRoom;
        base.Awake();
    }
    public void CreateRoom()
    {
        string data = "create";
        base.SendRequest(data);
    }
    public override void OnResponse(string data)
    {
        if(data.Equals(((int)ReturnCode.Success).ToString()))
        {
            gamecontroller.playerManager.IsHouseOwner=true;
            gamecontroller.GetUIPanel(UIPanelType.RoomPanel);
        }
        base.OnResponse(data);
    }
    public override void SendRequest(string data)
    {
        base.SendRequest(data);
    }
}