using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginPanel : BasePanel
{
    [SerializeField] private InputField usernameInput;
    [SerializeField] private InputField passwordInput;
    [SerializeField] private LoginRequest loginRequest;

    public override void Awake()
    {
        panelType = UIPanelType.LoginPanel;
        base.Awake();
    }
    public void OnClick()
    {
        string username = usernameInput.text;
        string passWord = passwordInput.text;

        loginRequest.SendRequest(username, passWord);

    }

}
