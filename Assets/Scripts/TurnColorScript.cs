using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class TurnColorScript : MonoBehaviour
{

    private Renderer rend;

    public void Start()
    {
        rend = GetComponent<Renderer>(); 
    }
    void OnEnable()
    {
        EventManager.OnClicked += TurnColor;  // += is operator to subscribe to an event
    
        SceneManager.sceneLoaded += FadeInOnSceneLoad; 
    }


    void FadeInOnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        // do stuff
    }

    void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;  // -= is the operator to unsubscribe from an event
    }



    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        if(rend != null) rend.material.color = col;
    }
}