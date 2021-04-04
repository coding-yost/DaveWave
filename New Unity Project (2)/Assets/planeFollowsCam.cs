using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeFollowsCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public Transform objectToFollow = Camera.main.transform;
    public Vector3 offset;
    void Update()
    {
        transform.position = objectToFollow.position + offset;
    }
}
