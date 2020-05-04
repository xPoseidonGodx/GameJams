using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlCanvas : MonoBehaviour
{
    public static ControlCanvas instance;
    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowGameOver(){
        GameOverPanel.SetActive(true);
    }
    public void RestartGame(string lvl){
            SceneManager.LoadScene(lvl);
    }
    public void netxScene(string lvl1){
        SceneManager.LoadScene(lvl1);
    }   
}
