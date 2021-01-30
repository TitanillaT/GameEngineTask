using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIntro : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float speed = 10f; 


    void Start()
    // Move paint bucket to the left
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
            speed -= 0.01f; 
    }

    // Update is called once per frame
    void Update()
    {   
            
    }
        



}
