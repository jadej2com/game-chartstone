using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot1 : Enemy, IDamageable
{
    public int Health { get; set; }
    public GameObject laser;
    public GameObject[] items;
 
    public override void Init()
    {
        base.Init();
        Health = base.health;
    }

    public override void Movement()
    {
        base.Movement();
      
    }

    public override void Update()
    {
        base.Update();
        if (_anim.GetBool("InCombat"))
        {
            StartCoroutine(Attack());
        }
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
            
            if(items != null)
            {

                items[Random.Range(0, items.Length)].SetActive(true);
                //items[0].SetActive(true);
            }
        }
        
    }


    IEnumerator Attack()
    {
        yield return new WaitForSeconds(0.5f);
        //Instantiate(laser, transform.position, Quaternion.identity);
        GameObject newBullet = Instantiate(laser, transform.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = -transform.right * speed;
        yield return new WaitForSeconds(0.5f);
        Destroy(newBullet);
    }
    


}
