using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorSpin : MonoBehaviour
{
    // public GameObject propeller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(Vector3.forward * 10);
    }
}
