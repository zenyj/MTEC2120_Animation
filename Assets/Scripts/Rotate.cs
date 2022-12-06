using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float speed = 10.0f;
    private float roty = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Method 1
        roty += speed * Time.deltaTime;
        transform.localEulerAngles = new Vector3(0, roty, 0); 

        // Method 2
        //transform.Rotate(new Vector3(0, Time.deltaTime * speed, 0));
    }
}
