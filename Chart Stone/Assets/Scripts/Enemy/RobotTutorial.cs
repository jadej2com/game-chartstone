using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotTutorial : Enemy, IDamageable
{
    public int Health { get; set; }
    public GameObject laser;
    public GameObject item;

    public override void Init()
    {
        base.Init();
        Health = base.health;
       
    }

    public override void Movement()
    {
        base.Movement();

    }

    
    public void Damage()
    {
       
        Debug.Log("Damage");
        Health--;
        _anim.SetTrigger("Hit");
        _anim.SetBool("InCombat", true);
        isHit = true;
        if (Health < 1)
        {
          
            isDead = true;
            _anim.SetTrigger("Death");
            //item.transform.position = transform.position;
            if (item != null)
            {
                item.SetActive(true);
            }
        }

    }

   
    public void Attack()
    {
        Instantiate(laser, transform.position, Quaternion.identity);
    }


}
