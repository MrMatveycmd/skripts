using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpsMove : MonoBehaviour
 
{
   public int health = 5;
   public int level = 1;
   public float speed = 1.2f;
   
    void Start()
    {
        health += level;
        print(health);

    }

    
    void Update()
    {
        Vector3 NewPosition = transform.position;
        NewPosition.z += speed * Time.deltaTime;
        transform.position = NewPosition;

    }
}
