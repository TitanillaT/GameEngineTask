using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIntro : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 1.5f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        
    }


}
