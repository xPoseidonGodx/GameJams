using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationOasis : MonoBehaviour
{
    public Transform Center;
    public bool released;
    public SpriteMask mask;
    public GameObject Oasis;
    private GameObject OasisFonte;
    public GameObject lightP;
    void Awake(){
       OasisFonte = GameObject.FindGameObjectWithTag("OasisFonte");
        Oasis = GameObject.FindGameObjectWithTag("Oasis");
    }
    void Start()
    {
        mask.enabled = false;
    }
    void Update()
    {
        maskCreating();
        maskDisable();
    }
    void maskCreating(){
        if(Input.GetButtonDown("Fire1") && mask.enabled == false && released){
            Instantiate(Oasis, new Vector3(Center.transform.position.x,Center.transform.position.y,Center.transform.position.z), Center.transform.rotation);
           Oasis.SetActive(true);
           mask.enabled = true;
           Time.timeScale = 0.8f;
           Player.instance.speed = 0;
           Player.instance.JumpForce *= 2;
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
    void OnTriggerEnter2D(Collider2D outro){
        if(outro.gameObject.CompareTag("OasisFonte")){
            released = true;
            Destroy(OasisFonte);
            Destroy(lightP);
        }
    }
}
