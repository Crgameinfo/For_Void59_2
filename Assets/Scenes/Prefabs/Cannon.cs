using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform shoot_point;
    public Rigidbody rocket;
    public float shoot_speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,Input.GetAxis("Horizontal")*Time.deltaTime*100f,0);
        if (Input.GetKeyDown(KeyCode.Space)) 
              {
                  fire1();
              }
             
        
    }
    void fire1 () 
	{   
		
        Rigidbody rocketClone = (Rigidbody) Instantiate(rocket, shoot_point.transform.position, shoot_point.transform.rotation);	
		rocketClone.velocity = shoot_point.transform.right * shoot_speed;
		//audio.PlayOneShot(fire1_sound, 0.5F);
	}
}
