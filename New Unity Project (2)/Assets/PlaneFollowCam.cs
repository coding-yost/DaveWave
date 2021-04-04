using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFollowCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform objectToFollow;
    public Vector3 offset;
    void Update()
    {
        transform.position = objectToFollow.position + offset;
    }
}
