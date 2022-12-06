using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public int numPrefabs;
    public float radius = 10;

    private Transform myTransform; 



    // Start is called before the first frame update
    void Start()
    {
        // Declaring variables allocates memory
        Vector3 position;
        Vector3 localRot;
        Quaternion rotation;

        for (int i = 0; i < numPrefabs; i++)
        {

             position = Random.insideUnitSphere * radius;
             localRot = Random.insideUnitSphere * 360.0f;
             rotation = Quaternion.Euler(localRot); 

            GameObject go = Instantiate(prefab, position, rotation);
            Collider col = go.GetComponent<Collider>(); 
            if(col !=null)
            {
                // do something. 
            }
            //col.enabled = true; // could result in a null
            //reference error. 

            myTransform = this.transform;
 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
