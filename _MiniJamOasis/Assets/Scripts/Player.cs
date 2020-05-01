 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
        public float speed, speedNormal;
        public float JumpForce,JumpForceNormal;
        private bool isJumping;
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
        move();
        Jump();
    }
    void move(){
        Vector3 movement = new  Vector3(Input.GetAxis("Horizontal"),0,0);
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
        if(Input.GetButton("Jump") && !isJumping){
            _rb.AddForce(new Vector2(0,JumpForce * Time.deltaTime), ForceMode2D.Impulse);
            _anim.SetBool("Jump",true);
             _anim.SetBool("Idle", false);
              _anim.SetBool("Run", false);
        }
    }
       void OnCollisionEnter2D(Collision2D outro){
        if(outro.gameObject.layer == 8){
            isJumping = false;
        }
    }
    void OnCollisionExit2D(Collision2D outro){
        if(outro.gameObject.layer == 8){
            isJumping = true;
        }
    }
}