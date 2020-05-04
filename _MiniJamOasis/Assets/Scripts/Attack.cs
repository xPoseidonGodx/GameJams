using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public int times;
    public Image[] Imagens;
    private bool isJumping;
    private bool attacking;
    private Animator _anim;
    void Start()
    {
        _anim = GetComponent<Animator>();
    }
    void Update()
    {
        attack();
        switch(times){
            case 13:
            Imagens[13].enabled = false;
            break;
            case 12:
            Imagens[12].enabled = false;
            break;
            case 10:
            Imagens[10].enabled = false;
            break;
            case 9:
            Imagens[9].enabled = false;
            break;
            case 8:
            Imagens[8].enabled = false;
            break;
            case 7:
            Imagens[7].enabled = false;
            break;
            case 6:
            Imagens[6].enabled = false;
            break;
            case 5:
            Imagens[5].enabled = false;
            break;
            case 4:
            Imagens[4].enabled = false;
            break;
            case 3:
            Imagens[3].enabled = false;
            break;
            case 2:
            Imagens[2].enabled = false;
            break;
            case 1:
            Imagens[1].enabled = false;
            break;
            case 0:
           Imagens[0].enabled = false;
            break;
                    }
    }
     void attack(){
        if(Input.GetKeyDown(KeyCode.Z) && times >= 1){
            _anim.SetBool("Attack", true);
             _anim.SetBool("Idle", false);
             _anim.SetBool("Run", false);
            attacking = true;
        }
    }
    public void ExitAttack(){
        _anim.SetBool("Attack", false);
        attacking = false;
        times -= 1; 
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
