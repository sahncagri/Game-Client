using UnityEngine;

public class LoginRequest:BaseRequest 
{
    private LoginPanel loginPanel;
    public override void Awake() {
        requestCode = RequestCode.User;
        actionCode = ActionCode.Login;
        loginPanel = GetComponent<LoginPanel>();
        base.Awake();
    }
    public void SendRequest(string username,string password)
    {
        string data = username+","+password;
        base.SendRequest(data);
    }
    public override void OnResponse(string data)
    {
        base.OnResponse(data);
        Debug.Log(data+"Giris Basarili");
        gamecontroller.GetUIPanel(UIPanelType.LobbyPanel);
    }
}