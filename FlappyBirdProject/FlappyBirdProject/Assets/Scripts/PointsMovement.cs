using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointsMovement : MonoBehaviour
{

    public float speed = 4;
   
    // Switch Movement Direction every 2 seconds
    public float switchTime = 4;

    void Start() {
        // Initial Movement Direction
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
       
        // Switch enemy movement every few seconds
        InvokeRepeating("Switch", 0, switchTime);
    }
    void Update()
    {

        
        transform.Translate(Vector3.left * Time.deltaTime * speed * Random.Range(3f,10f));
        if(transform.position.x < -15f)
        {
            transform.position = new Vector3(15f,transform.position.y,0);
        }

    }
    void Switch() {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && gameObject.tag != "GreenBall")
        {
            SceneManager.LoadScene(0);
        }
        else if(other.tag == "Player" && gameObject.tag == "GreenBall")
        {
            BirdyFly birdy = other.GetComponent<BirdyFly>();
            if(birdy != null)
            {
                birdy.IncreaseScore();
            }
            transform.position = new Vector3(15f,transform.position.y,0);
        } 
    }
}
