using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    void Update()
    {
        //The ability to rotate the camera by degrees.
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
    } 
}
