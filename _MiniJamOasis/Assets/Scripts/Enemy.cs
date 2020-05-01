using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]private int life;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Dying(){
        if(life <= 0){
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D outro){
        if(outro.gameObject.CompareTag("Attack")){
            life--;
            Dying();
        }
    }
}
