using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retate3 : MonoBehaviour
{
    public Vector3 vect1;
    void Start()
    {
        vect1 = new Vector3(0, 0.3f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.3f, 0);
    }
}


