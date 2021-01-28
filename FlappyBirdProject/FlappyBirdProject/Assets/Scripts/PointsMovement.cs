using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointsMovement : MonoBehaviour
{

    [SerializeField]
    public float _speed = 2;
   
    // Switch Movement Direction every 2 seconds
    // public float switchTime = 4;

    void Start() {
        // Initial Movement Direction
        // GetComponent<Rigidbody2D>().velocity = Vector2.left * _speed;
       
        // Switch enemy movement every few seconds
        // InvokeRepeating("Switch", 0, switchTime);
    }
    void Update()
    {

        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if(transform.position.x < -10f)
        {
            transform.position = new Vector3(Random.Range(12f,17f),Random.Range(-1f,1f),0);
        }
    

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player" && gameObject.tag == "GreenBall")
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
