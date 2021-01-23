using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadPointMovement : MonoBehaviour
{

    [SerializeField]
    public float _speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        // if(transform.position.x < -15f)
        // {
        //     transform.position = new Vector3(15f,Random.Range(-1f,1f),0);
        // }

        transform.position = new Vector3(Random.Range(12f,17f),Random.Range(-5f,5f),Random.Range(5f,5f));

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if(transform.position.x < -15f)
        {
            transform.position = new Vector3(15f,Random.Range(-1f,1f),0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    { 
       if(other.tag == "shooter") 
       {    
            // Creates Random Ball after gets Destorys
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
            transform.position = new Vector3(15f,Random.Range(-2f,2f),0);
            // Destorys Ball
            Destroy(GetComponent<BoxCollider>());
            
       } else {
            
            SceneManager.LoadScene(0);

       }
    }
            
}
