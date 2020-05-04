using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCollision : MonoBehaviour
{   
    public Animator Player;
    public bool isGround;
    // Start is called before the first frame update
    void Awake(){
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D outro){
        if(outro.gameObject.layer == 8){
            Player.SetBool("Jump", false);
            Player.SetBool("Idle", true);
            isGround = true;
        }
    }
     void OnCollisionExit2D(Collision2D outro){
        if(outro.gameObject.layer == 8){
            isGround = false;
        }
    }
}
