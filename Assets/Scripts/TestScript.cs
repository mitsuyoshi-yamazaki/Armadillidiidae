using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// public class RotateToNearestSide : MonoBehaviour
public class TestScript : MonoBehaviour
{
    public float hoge = -20f;

    void Update()
    {
        float angle = 120.0f;
        Vector3 axis = new Vector3(0, 0, 1);

        transform.RotateAround(transform.position - new Vector3(0, hoge, 0), axis, angle * Time.deltaTime);
    }
}