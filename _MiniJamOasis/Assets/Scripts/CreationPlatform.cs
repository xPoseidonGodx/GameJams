using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationPlatform : MonoBehaviour
{
    public GameObject[] PlatformGround;

    public Animator _anim;
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
    void CreatePlat(){
       _anim.SetBool("Create", true);
    }

    void OnTriggerEnter2D(Collider2D outro){
        if(outro.gameObject.layer ==  11){
            CreatePlat();
        }
    }
}
