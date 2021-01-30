using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

        public void LoadGame() 
    {
        SceneManager.LoadScene("SampleScene");
        
    }


    void Update()
    {
        
        Text High_Score = GameObject.Find("Canvas/High_Score").GetComponent<Text>();

        High_Score.text = "High Score : " + BirdyFly.HighScore();
        Debug.Log("High score : " + BirdyFly.HighScore());
            
    }


}
