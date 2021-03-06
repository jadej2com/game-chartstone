using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //public GameObject Robot1;
    //public GameObject chest;
    private bool _canDamage = true;
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit : " + other.name);
        IDamageable hit = other.GetComponent<IDamageable>();
        if (hit != null)
        {
            if (_canDamage == true)
            {
                hit.Damage();
                _canDamage = false;
                StartCoroutine(ResetDamage());
            }
        }
    }

    IEnumerator ResetDamage()
    {
        yield return new WaitForSeconds(0.5f);
        _canDamage = true;
    }
}
