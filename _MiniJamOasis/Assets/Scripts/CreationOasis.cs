using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationOasis : MonoBehaviour
{
    public Transform Center;

    public SpriteMask mask;
    public GameObject Oasis;
    void Awake(){
        mask.enabled = false;
    }
    void Start()
    {

    }
    void Update()
    {
        maskCreating();
        maskDisable();
    }
    void maskCreating(){
        if(Input.GetButtonDown("Fire1") && mask.enabled == false){
            Instantiate(Oasis, new Vector3(Center.transform.position.x,Center.transform.position.y,Center.transform.position.z), Center.transform.rotation);
           Oasis.SetActive(true);
           mask.enabled = true;
           Time.timeScale = 0.6f;
           Player.instance.speed = 0;
           Player.instance.JumpForce = 0;
        }
    }
    void maskDisable(){
        if(Input.GetKeyDown(KeyCode.Mouse1) && mask.enabled == true){
                Oasis.SetActive(false);
                mask.enabled = false;
                Time.timeScale = 1f;
                Player.instance.speed = Player.instance.speedNormal;
                

            }
        }
}
