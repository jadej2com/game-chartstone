using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveOject : MonoBehaviour
{
    public float radius = 0.5f; //กำหนดระยะการชนและการมองเห็น
    public Transform interactItem;
    public Transform player;
    bool hasInteract = false;
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, interactItem.position);
        if(distance <= 1 && !hasInteract)
        {
            hasInteract = true;
            Interact();
        }
        else
        {
            hasInteract = false;
        }
    }

    public virtual void Interact()
    {
        Debug.Log("Item Active");
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactItem.position, radius);
    }
}
