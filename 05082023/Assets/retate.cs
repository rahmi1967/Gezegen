using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retate : MonoBehaviour
{
    public Vector3 yan;
    void Start()
    {
        yan = new Vector3 (0, 0.1f ,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform. Rotate(0,0.1f,0); 
    }
}
