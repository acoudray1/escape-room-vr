using System.Collections;
using UnityEngine;

public class InteractiveInterruptorObject : InteractiveObject
{
    [SerializeField] private GameObject associateGameObject;

    public override void Start()
    {
        base.Start();

        displayAssociateGameObject();
    }

   protected override void EClickActionCommonCase()
    {
        base.EClickActionCommonCase();
        displayAssociateGameObject();
    }

    /**
     * Show/Hide the associate GameObject switch isOpen value 
     **/
    private void displayAssociateGameObject()
    {
        if (associateGameObject != null)
        {
            associateGameObject.SetActive(base.isOpen);
        }
    }
}
