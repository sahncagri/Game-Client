using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum UIPanelType
{
    None,
    LoginPanel,
    LobbyPanel,
    RoomPanel
}
public class UIManager : BaseManager
{
    private Dictionary<UIPanelType, BasePanel> listPanels = new Dictionary<UIPanelType, BasePanel>();
    private bool canPanelActive;
    UIPanelType panelType;
    public UIManager(GameController controller) : base(controller)
    {

    }
    public override void Update()
    {
       if(canPanelActive)
       {
          GetPanel(panelType);
          canPanelActive=false;
       }
        base.Update();
    }
    public override void OnInit()
    {
        AddPanelToList();
        base.OnInit();
    }

    public void AddPanelToList()
    {
        var panelParent = GameObject.Find("Canvas/Panels").transform;
        listPanels.Add(UIPanelType.LoginPanel, panelParent.GetChild(0).GetComponent<BasePanel>());
        listPanels.Add(UIPanelType.LobbyPanel, panelParent.GetChild(1).GetComponent<BasePanel>());
        listPanels.Add(UIPanelType.RoomPanel, panelParent.GetChild(2).GetComponent<BasePanel>());
    }
    public void TogglePanel(UIPanelType panelType)
    {
       canPanelActive=true;
       this.panelType = panelType;
    }
    private void GetPanel(UIPanelType panelType)
    {
        foreach (var item in listPanels.Values)  item.gameObject.SetActive(false);
        BasePanel panel;
        listPanels.TryGetValue(panelType, out panel);
        panel.gameObject.SetActive(true);
    }
}
