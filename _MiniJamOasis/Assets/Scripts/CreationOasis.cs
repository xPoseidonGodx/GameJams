using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreationOasis : MonoBehaviour
{
    public bool released;
    public int times;
    public Transform Center;
    public Image[] Imagens; 
    public SpriteMask mask;
    public GameObject Oasis;
    private GameObject OasisFonte;
   
    void Awake(){
       OasisFonte = GameObject.FindGameObjectWithTag("OasisFonte");
        Oasis = GameObject.FindGameObjectWithTag("Oasis");
    }
    void Start()
    {
        times = 5;
    }
    void Update()
    {
        switch(times){
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

        maskCreating();
        maskDisable();
    }
    void maskCreating(){
        if(Input.GetButtonDown("Fire1") && released && times >= 1){
            Oasis.SetActive(true);
            mask.enabled = true;
            Time.timeScale = 1.5f;
           times -= 1;   
        }
    }
    void maskDisable(){
        if(Input.GetKeyDown(KeyCode.Mouse1)){
            if(mask.enabled == true){
                Oasis.SetActive(true);
                mask.enabled = false;
                Time.timeScale = 1f;
            }            
            }
        }
}
