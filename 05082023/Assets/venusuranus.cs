using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class venusuranus : MonoBehaviour
{
    public Vector3 vect3;
    void Start()
    {
        vect3=new Vector3(0,-0.2f,0);   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,-0.2f,0);
    }
}
