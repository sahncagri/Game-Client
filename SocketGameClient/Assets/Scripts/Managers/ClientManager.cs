using System;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using Common;
using UnityEngine;

public class ClientManager : BaseManager
{
    Socket clientSocket;
    private IPEndPoint endPoint;
    private string ipStr = "127.0.0.1";
    private int port = 9688;
    private Message message = new Message();
    public ClientManager() {}
    
    public ClientManager(GameController controller) : base(controller) { }

    public override void OnInit()
    {
        endPoint = new IPEndPoint(IPAddress.Parse(ipStr), port);
        clientSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        if(clientSocket == null) Debug.Log("null bnu ya ");
        clientSocket.Connect(endPoint);
        StartReceive();
        base.OnInit();
    }

    void StartReceive()
    {
        clientSocket.BeginReceive(message.Data,message.StartIndex,message.RemainSize,SocketFlags.None,OnReceiveCallback,null);
    }

    private void OnReceiveCallback(IAsyncResult ar)
    {
        int count = clientSocket.EndReceive(ar);
        message.ReadMessage(count,OnReadMessageCallback);
        StartReceive();
    }

    private void OnReadMessageCallback(ActionCode actionCode, string data)
    {
        gameController.HandleResponse(actionCode,data);
    }

    public void SendRequest(RequestCode requestCode,ActionCode actionCode,string data)
    {
        byte[] bytes = Message.PackData(requestCode,actionCode,data);
        clientSocket?.Send(bytes);
    }
   
}
