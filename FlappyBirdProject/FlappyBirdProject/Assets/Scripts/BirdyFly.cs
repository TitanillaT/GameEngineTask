using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdyFly : MonoBehaviour
{
    //player's points, +1 points 
    [SerializeField]
    private int points = 0;

    [SerializeField]
    private GameObject _shooter;

    [SerializeField]
    private float _fireRate = 0.5f;
    private float _canFire = -1f;

    // Movement speed
    float speed = 2;

    // Jump 
    float force = 375;

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
        
        if(Input.GetKeyDown(KeyCode.Tab) && Time.time > _canFire)
        {
            FireLaser();
        }
    }
    public void IncreaseScore()
    {
    Text showPoints = GameObject.Find("Canvas/Points").GetComponent<Text>();
    
       
      points += 1;
      // showPoints.text = "" + points + "Pts";
      showPoints.text = "" + points;
      
      Debug.Log("Player got 1 points! Total : " + points);
    }

    void FireLaser()
    {
        //Debug.Log("Space was pressed");
        //every 0.5 of a second it will allow us to fire
        _canFire = Time.time + _fireRate;

            // Position of player (0,0,0) + (0,1,0) = final position of the laser (0,1,0)
            Instantiate(_shooter,transform.position + new Vector3(1f,0,0), Quaternion.identity);

    }



}
