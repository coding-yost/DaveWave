using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        //Console.WriteLine("Hello World");
        //Renderer render = GetComponent<Renderer>();
        //render.material.color = Color.green;
    }


}
