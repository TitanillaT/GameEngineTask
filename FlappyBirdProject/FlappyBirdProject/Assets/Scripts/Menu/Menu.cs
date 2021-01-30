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
        BirdyFly birdy = GetComponent<BirdyFly>();
        Text High_Score = GameObject.Find("Canvas/High_Score").GetComponent<Text>();
        
        High_Score.text = "High Score : " + birdy.HighScore();
        Debug.Log("High score : " + birdy.HighScore());
            
    }


}
