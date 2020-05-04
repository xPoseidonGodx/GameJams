using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Dead(){
        gameObject.SetActive(false);
        ControlCanvas.instance.ShowGameOver();
    }
    void OnTriggerEnter2D(Collider2D outro){
        if(outro.gameObject.CompareTag("Abism")){
            Dead();
        }
        
    }
    void OnCollisionEnter2D(Collision2D outro){
        if(outro.gameObject.CompareTag("Enemy")){
            Dead();     
        }
    }
}
