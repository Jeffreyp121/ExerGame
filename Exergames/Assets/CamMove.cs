using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform target;
    public static float x;
    public static float y;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = target.transform.position.x + 5f;
        position.y = 3f;
       // position.y = target.transform.position.y;
        transform.position = position;
    }
}