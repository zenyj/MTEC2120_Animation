using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.OnFloat += Move;  // += is operator to subscribe to an event
    }

    public void Move(float val)
    {
        transform.position += new Vector3(0, val, 0);

    }

    private void OnDisable()
    {
        EventManager.OnFloat -= Move;  // += is operator to unsubscribe to an event
    }



}
