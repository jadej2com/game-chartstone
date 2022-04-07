using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour , IDamageable
{
    private Rigidbody2D _rigid;
    [SerializeField]
    public float _jumpForce = 7.0f;
    private bool _resetJump = false;
    [SerializeField]
    private float _speed = 3.0f;

    [SerializeField]
  

    private PlayerAnimation _playerAnim;
    private SpriteRenderer _playerSprite;
    private SpriteRenderer _swordArcSprite;

 
    public Joystick _joystick;
            
    Rigidbody2D rb2d;
    BoxCollider2D bcol;

    [SerializeField] private LayerMask GroundLayer;
    private bool _grounded = false;
    public int Health { get;  set; }
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        _rigid = GetComponent<Rigidbody2D>();
        _playerAnim = GetComponent<PlayerAnimation>();
        _playerSprite = GetComponentInChildren<SpriteRenderer>();
        

        _swordArcSprite = transform.GetChild(1).GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
        Health = 100;

    }
    void Update()
    {


        Movement();

        if (ButtonHolding.instance.holding)
        {
            Fly();

        }



    }
    public void QuitButton()
    {
        Application.Quit();
    }

    public void BtnAttack()
    {
        // if (Input.GetMouseButtonDown(0) && IsGrounded())
        if (IsGrounded())
        {
            _playerAnim.Attack();
        }


    }

    void Movement()
    {
        float move = _joystick.Horizontal;//Input.GetAxisRaw("Horizontal");
        _grounded = IsGrounded();

        
            Flip(move);
            _rigid.velocity = new Vector2(move * _speed, _rigid.velocity.y);
            _playerAnim.Move(move);
        



    }


    

    public void Fly()
    {
      
        if(BarPanel.instance.energy > 0)
        {
            
            _rigid.velocity = new Vector2(_rigid.velocity.x, 5.0f);
             BarPanel.instance.energy -=  0.1f;
           

        }
    }

   
   

    public void PlayerJump()
    {
        //  if (Input.GetKeyDown(KeyCode.Space) && IsGrounded() == true)
        if (IsGrounded())
        {
            //jump!
            Debug.Log("Jump");

            _rigid.velocity = new Vector2(_rigid.velocity.x, _jumpForce);
            StartCoroutine(ResetJumpRoutine());

            _playerAnim.Jump(true);

        }





    }

    void Flip(float move)
    {
        if (move > 0)
        {

            _playerSprite.flipX = true;
            //_swordArcSprite.flipX = true;
           _swordArcSprite.flipY = false;

      
            
            Vector3 newPos = _swordArcSprite.transform.localPosition;
            newPos.x = 0.85f;
            _swordArcSprite.transform.localPosition = newPos;
        }
        else if (move < 0)
        {
            _playerSprite.flipX = false;
            //_swordArcSprite.flipX = true;
            _swordArcSprite.flipY = true;

          

            Vector3 newPos = _swordArcSprite.transform.localPosition;
            newPos.x = -0.85f;
            _swordArcSprite.transform.localPosition = newPos;
        }

    }

    bool IsGrounded()
    {

        // RaycastHit2D raycastHit = Physics2D.BoxCast(bcol.bounds.center, bcol.bounds.size, 0f, Vector2.down, 1f, GroundLayer);
        // Color rayColor;
        // if (raycastHit.collider != null)
        // {
        //     rayColor = Color.green;
        // }
        // else
        // {
        //     rayColor = Color.red;
        // }
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.down, 1f, GroundLayer);
        Debug.DrawRay(transform.position, Vector2.down, Color.green);

        if (hitInfo.collider != null)
        {
            if (_resetJump == false)
            {

                _playerAnim.Jump(false);
                return true;
            }
        }
        return false;
    }

    //หน่วงเวลา
    IEnumerator ResetJumpRoutine()
    {
        _resetJump = true;
        yield return new WaitForSeconds(0.1f);
        _resetJump = false;

        // Debug.Log("wait");
    }

   
    public void Damage()
    {
        Debug.Log("Player :: Damage() ");
        Health -= 10;
        BarPanel.instance.UpdateLives(Health);
        if(Health < 1)
        {
            _playerAnim.Death();
        }
    }




}
