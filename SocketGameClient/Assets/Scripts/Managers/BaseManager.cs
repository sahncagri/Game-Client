using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManager
{
   protected GameController gameController;
   public BaseManager(){}
   protected BaseManager(GameController controller){
      this.gameController=controller;
   }
    public virtual void OnInit() { }
	public virtual void OnDestroy() { }
    public virtual void Update() { }
}
