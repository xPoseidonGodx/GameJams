 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
        public float speed;
        public float JumpForce;
        private bool isJumping;
        private bool isGround ;
        private SpriteRenderer _sr;
        private Rigidbody2D _rb;
        private Animator _anim;
   void Awake(){
       _rb = GetComponent<Rigidbody2D>();
       _sr = GetComponent<SpriteRenderer>();
       _anim = GetComponent<Animator>();
   }
    void Start()
    {
        instance = this;
    }
    void Update()
    {
        
    }
    void FixedUpdate(){
        move();
        Jump();
    }
    void move(){
        Vector3 movement = new  Vector3(Input.GetAxis("Horizontal") ,0,0);
        transform.position += movement * speed * Time.deltaTime;
        if(Input.GetAxis("Horizontal") > 0.1f){
            _anim.SetBool("Run", true);
             _anim.SetBool("Idle", false);
            _sr.flipX = false;
        }
        else if(Input.GetAxis("Horizontal") < -0.1f){
            _anim.SetBool("Run", true);
            _anim.SetBool("Idle", false);
            _sr.flipX = true;
        }
        else {
            _anim.SetBool("Idle", true);
             _anim.SetBool("Run", false);
            _sr.flipX = false;
        }
    }
    void Jump(){
        if(Input.GetButton("Jump")){
            if(!isJumping){
                _rb.AddForce(new Vector2(0,JumpForce * Time.deltaTime), ForceMode2D.Impulse);
            _anim.SetBool("Jump", true);
             _anim.SetBool("Idle", false);
             _anim.SetBool("Run", false);
            }
        }              
    }
       void OnCollisionEnter2D(Collision2D outro){
        if(outro.gameObject.layer == 8 || outro.gameObject.layer == 10){
            isJumping = false;
            isGround = true;
            _anim.SetBool("Jump", false);
        }
    }
    void OnCollisionExit2D(Collision2D outro){
        if(outro.gameObject.layer == 8 || outro.gameObject.layer == 10){
            isJumping = true;
            isGround = false;
        }
    }
}