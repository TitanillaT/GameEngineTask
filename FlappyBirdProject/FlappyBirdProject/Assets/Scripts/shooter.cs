using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]
    private float _speed = 8;


    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //make the laser move right
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
        //if laser position is great than 15 on the x axis
        if(transform.position.x > 15 && gameObject != null) 
        {
            
            // check if there is a parent 
            if(transform.parent != null)
            {
                // destory parent
                Destroy(transform.parent.gameObject);

                
            }
            //destroy the laser after moving 15 
            // Destroy(gameObject);
        }

    }
}
