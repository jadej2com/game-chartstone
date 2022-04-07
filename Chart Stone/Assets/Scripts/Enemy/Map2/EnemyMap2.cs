using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMap2 : MonoBehaviour
{
    [SerializeField]
    protected int health;
    [SerializeField]
    protected float speed;
    [SerializeField]
    protected int gems;
    [SerializeField]
    protected Transform pointA, pointB;

    protected Animator _anim;
    protected SpriteRenderer Sprite;
    protected Vector3 _currentTarget;
    protected bool isHit = false;
    protected Player2 player;
    protected bool isDead = false;
    public virtual void Init()
    {
        _anim = GetComponentInChildren<Animator>();
        Sprite = GetComponentInChildren<SpriteRenderer>();
        GameObject gameObject1 = GameObject.FindGameObjectWithTag("Player");
        player = gameObject1.GetComponent<Player2>();



    }
    private void Start()
    {
        Init();
    }

    public virtual void Update()
    {
        if (_anim.GetCurrentAnimatorStateInfo(0).IsName("Idle") && _anim.GetBool("InCombat") == false)
        {
            return;
        }
        if (isDead == false)
        {
            Movement();

        }
        else
        {



            StartCoroutine(DelayDestroy());
        }


    }

    IEnumerator DelayDestroy()
    {

        yield return new WaitForSeconds(0.8f);
        Destroy(this.gameObject.GetComponent<BoxCollider2D>());
        Destroy(this.gameObject.transform.GetChild(0).GetComponentInChildren<SpriteRenderer>());

        // Debug.Log("wait");
    }

    public virtual void Movement()
    {

        if (_currentTarget == pointA.position)
        {
            Sprite.flipX = true;
        }
        else
        {
            Sprite.flipX = false;

        }

        if (transform.position == pointA.position)
        {
            _currentTarget = pointB.position;
            _anim.SetTrigger("Idle");

        }
        else if (transform.position == pointB.position)
        {
            _currentTarget = pointA.position;
            _anim.SetTrigger("Idle");

        }

        if (isHit == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, _currentTarget, speed * Time.deltaTime);

        }


        //Chick distance between player and enemy
        float distance = Vector2.Distance(transform.position, player.transform.position);


        if (distance > 4.0f)
        {
            // Debug.Log("Dustance : " + distance +"for " + transform.name);

            isHit = false;
            _anim.SetBool("InCombat", false);
        }
        Vector2 direction = player.transform.localPosition - transform.localPosition;
        // Debug.Log("side" + direction.x);

        if (direction.x > 0 && _anim.GetBool("InCombat") == true)
        {
            Sprite.flipX = false;

        }
        else if (direction.x < 0 && _anim.GetBool("InCombat") == true)
        {
            Sprite.flipX = true;
        }
    }

    // public abstract void Update(); //use when want to override


}
