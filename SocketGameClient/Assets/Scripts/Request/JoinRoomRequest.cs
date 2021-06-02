public class JoinRoomRequest : BaseRequest 
{
    public override void Awake()
    {
        requestCode = RequestCode.Room;
        actionCode = ActionCode.JoinRoom;
        base.Awake();
    }
    public void JoinRoom()
    {
        
    }
     public override void OnResponse(string data)
    {

        base.OnResponse(data);
    }
    public override void SendRequest(string data)
    {
        base.SendRequest(data);
    }    

}