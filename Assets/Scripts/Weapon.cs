using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float rate = 0.1f;

    public float velocity = 100.0f;
    public float damage = 100.0f;
    public GameObject entity;
    public GameObject pattern;

    public Transform weapon_transform;
    // Start is called before the first frame update
    //applies to both enemies and the player
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
