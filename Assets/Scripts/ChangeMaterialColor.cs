using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{

    // Place this on any gameObject with a Render.

    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        Material mat = new Material(this.rend.material);
        mat.color = Color.red;
        rend.material = mat;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
