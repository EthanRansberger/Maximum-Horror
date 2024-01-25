using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playable : MonoBehaviour
{
    //public float speed = 0.1f;
   // public float rotationSpeed = 100.0f;
    Vector3 movpos;
    //public GameObject player;
    //public Transform player_transform;
    //public GameObject weapon;

    // public Transform player_position;
    // Start is called before the first frame update
    //public void Example()
   // {
    //    grandChild = this.gameObject.child 
   // }
    
    void Start() 
        
    {
        player = new GameObject("player");
        print("test");
       // player_position = new Transform("player_position");
    }

    // Update is called once per frame
    void Update()
    {
        InputHandler();
    }

    void InputHandler()
    {
        float transy = transform.position.y;
        float transx= transform.position.x;
        // float translation = Input.GetAxis("Vertical") * speed;
        if (Input.GetKey("w"))
        {
            transy += speed;
            // print(transy);
        }
        if (Input.GetKey("s"))
        {
            transy -= speed;
          
        }
        if (Input.GetKey("d"))
        {
            transx += speed;
         
        }
        if (Input.GetKey("a"))
        {
            transx -= speed;
            
        }
        if (Input.GetMouseButtonDown(0))
        {
            attack();
        }   
        movpos.Set(transx, transy, 0);
        transform.position = movpos;

        
        //  #transform.Translate(Vector3(transx,transy,0));

    }
    void attack()
    {
        Vector3 target = Input.mousePosition;
    }
}


