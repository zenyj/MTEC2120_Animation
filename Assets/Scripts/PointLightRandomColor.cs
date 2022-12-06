using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light) )]
public class PointLightRandomColor : MonoBehaviour
{

    Light pointLight;

    public Color[] colors; 
    // Start is called before the first frame update
    void Start()
    {
        pointLight = GetComponent<Light>();
        //pointLight.color = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
        pointLight.color = colors[Random.Range(0, colors.Length)];


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
