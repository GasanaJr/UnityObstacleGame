using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    public Rigidbody rb;
    MeshRenderer render;
    private void Start()
    {
       rb =  GetComponent<Rigidbody>();
       render = GetComponent<MeshRenderer>();
       render.enabled = false;
       rb.useGravity = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= 3)
        {
            render.enabled = true;
            rb.useGravity = true;
        }
    }
}
