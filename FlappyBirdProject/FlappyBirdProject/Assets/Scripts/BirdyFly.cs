using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdyFly : MonoBehaviour
{
    //player's points, +10 points 
    [SerializeField]
    private int points = 0;
    // Movement speed
    float speed = 2;

    // Spacebar 
    float force = 300;

    private int topPoints = 0;


    // Start is called before the first frame update
    void Start()
    {
      // gets player started
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;

    }

    // Update jump for every frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);

    }
    public void IncreaseScore()
    {
    Text showPoints = GameObject.Find("Canvas/Points").GetComponent<Text>();
    
       
      points += 10;
      showPoints.text = "" + points + "Pts";

      
      Debug.Log("Player got 10 points! Total : " + points);
    }

}
