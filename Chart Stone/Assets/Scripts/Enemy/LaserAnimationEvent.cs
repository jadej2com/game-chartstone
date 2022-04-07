using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAnimationEvent : MonoBehaviour
{
   
    private Robot1 _robot1;

    private void Start()
    {
        _robot1 = transform.parent.GetComponent<Robot1>();
    }
    public void Fire()
    {
        Debug.Log("Laser!");
        //_robot1.Attack();
    }
}
