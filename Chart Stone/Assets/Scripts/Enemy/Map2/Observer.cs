using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : EnemyMap2, IDamageable
{
    public int Health { get; set; }
    public GameObject[] items;
    public Transform firePoint;
    public GameObject bulletPrefab;
    private bool shooting = false;
    public override void Init()
    {
        base.Init();
        Health = base.health;
    }

    public override void Movement()
    {

        base.Movement();
        Attack();

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
            _anim.SetBool("InCombat", false);
            isDead = true;
            _anim.SetTrigger("Death");
            if (items != null)
            {
                
                items[Random.Range(0, items.Length)].SetActive(true);
            }
        }
        
    }
   


     public void Attack()
     {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.localPosition - transform.localPosition;
        if (distance < 4.0f)
        {

            
            if (shooting == true)
            {
                Shoot();
            }
            StartCoroutine(Wait());
        }


    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }

    IEnumerator Wait()
    {
        shooting = true;

        yield return new WaitForSeconds(0.8f);
        shooting = false;


        // Debug.Log("wait");
    }


}
