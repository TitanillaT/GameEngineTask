using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float _speed = 80;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make the laser move right
        transform.Translate(Vector3.right * _speed * Time.deltaTime);

        //if laser position is great than 8 on the y axis
        if(transform.position.x > 8)
        {
            // check if there is a parent 
            if(transform.parent != null)
            {
                // destory parent
                Destroy(transform.parent.gameObject);
                
            }
            //destroy the laser
            Destroy(gameObject);
        }

    }
}
