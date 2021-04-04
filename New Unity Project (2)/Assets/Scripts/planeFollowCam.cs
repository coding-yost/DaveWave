using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planFollowCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    var cameraToFollow : Transform;

    // Update is called once per frame
    void Update()
    {
        .position.z = cameraToFollow.position.z + 10;
    }
    
}
