using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

        public void LoadGame() 
    {
        SceneManager.LoadScene("SampleScene");
        
    }
    // [SerializeField]
    // private GameObject _startingText;
    

    //     public void LoadGame() 
    // {
    //     _startingText.SetActive(true);
    //     StartCoroutine(GameOverFlickerRoutine());
        
    // }

    // IEnumerator GameOverFlickerRoutine() 
    // {
    //         yield return new WaitForSeconds(3f);
    //         SceneManager.LoadScene("SampleScene");
        
    // }
}
