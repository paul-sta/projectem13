using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    Quaternion DefaultRotation;
    Vector3 Distance;
    public float maxdistance = 20;
    public GameObject camera;
    public GameObject target;
    void Start()
    {
        DefaultRotation = camera.transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(camera.transform.position, target.transform.position) <= maxdistance)
        {
            camera.transform.LookAt(target.transform);
        }
        else
        {
            camera.transform.rotation = DefaultRotation;
        }
    }
}
