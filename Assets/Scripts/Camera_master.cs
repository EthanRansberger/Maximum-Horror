using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_master : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    Vector3 campos;
    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("player");
        campos.Set(player.transform.position.x,player.transform.position.y,-10);
        transform.position = campos;
      //  player = Transform.Find("player_position");
      ////// transform.Translate(player.transform,0);
    }
}
