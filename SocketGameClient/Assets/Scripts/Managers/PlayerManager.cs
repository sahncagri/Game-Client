using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : BaseManager
{
    public PlayerManager() { }
    public PlayerManager(GameController controller) : base(controller)
    {

    }
    private bool isHouseOwner;
    public bool IsHouseOwner
    {
        get;
        set;
    }

}
