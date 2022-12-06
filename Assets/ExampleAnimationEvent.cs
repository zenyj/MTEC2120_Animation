// This C# function can be called by an Animation Event
using UnityEngine;
using System.Collections;
using Kvant; 

public class ExampleAnimationEvent : MonoBehaviour
{
    public GameObject spray; 

    Spray sprayParticle;


    private void Start()
    {
        sprayParticle = spray.GetComponent<Spray>(); 
    }


    public void Spray(float duration)
    {
        Debug.Log("Spray Particle");
        StartCoroutine(SprayForDuration(duration));
    }


    IEnumerator SprayForDuration(float duration)
    {
        sprayParticle.throttle = 0.5f;
        Debug.Log("SprayForDuration  " + duration);

        yield return new WaitForSeconds(duration);

        sprayParticle.throttle = 0.0f; 
    }

    public void PrintEvent(string s)
    {
        Debug.Log("PrintEvent: " + s + " called at: " + Time.time);
    }
}
