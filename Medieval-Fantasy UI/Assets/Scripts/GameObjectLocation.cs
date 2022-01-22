using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectLocation : MonoBehaviour
{
    public Transform gameObject;
    public float postionX, postionY, postionZ;

    void Start()
    {
        gameObject.position = new Vector2(postionX, postionY);   
    }

}
