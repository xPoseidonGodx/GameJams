using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private bool isJumping;
    private bool attacking;
    private Animator _anim;
    void Start()
    {
        _anim = GetComponent<Animator>();
    }
    void Update()
    {
        while(attacking){
            Player.instance.speed = 0;
        }
     attack();
    }
     void attack(){
        if(Input.GetKeyDown(KeyCode.Z) && !isJumping){
            _anim.SetBool("Attack", true);
             _anim.SetBool("Idle", false);
             _anim.SetBool("Run", false);
            attacking = true;
        }
    }
    public void ExitAttack(){
        _anim.SetBool("Attack", false);
        _anim.SetBool("Idle", true);
        _anim.SetBool("Run", true);
        attacking = false;
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
