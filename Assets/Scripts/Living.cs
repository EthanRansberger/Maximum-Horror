using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living : MonoBehaviour
{
    public float speed = 0.1f;
    public float rotationSpeed = 100.0f;
    Vector3 movpos;
    public GameObject currentity;
    public Transform entity_transform;
    public GameObject entity_weapon;
    public float health = 1.0f;
    public float defense = 1.0f;
    public string armor = "None";
    // Start is called before the first frame update
    void Start()
    {
        currentity = new GameObject("player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
