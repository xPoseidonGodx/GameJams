using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCollision : MonoBehaviour
{
    public Animator _sr;
    private bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGround){
            _sr.SetBool("Jump", false);
            _sr.SetBool("Idle", true);
              _sr.SetBool("Run", true);
        }
    }

    void OnCollisionEnter2D(Collision2D outro){
        if(outro.gameObject.layer == 8){
            isGround = true;
        }
    }
     void OnCollisionExit2D(Collision2D outro){
        if(outro.gameObject.layer == 8){
            isGround = false;
        }
    }
}
