using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : InteractiveOject
{
    public Item item;
    public override void Interact()
    {
        base.Interact();
        Pickup();
    }

    void Pickup()
    {
        Inventory.instance.Add(item);
        Destroy(gameObject);
    }
}
