using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI; 
using System.Collections;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction(); // delegate void with no signature
    public static event ClickAction OnClicked;



    //public UnityEvent doSomething; 

    public delegate void FloatAction(float val); // delegate void with float signature
    public static event FloatAction OnFloat;


    public delegate int IntAction();  // delegate int type with no signature. 
    public static event IntAction OnInt;


    public void Start()
    {
 
    }

    public int IntButton()
    {

        return 0; 
    }
    public void ButtonPressed()
    {
        if (OnClicked != null)
            OnClicked(); // broadcasts event to all listeners

        if (OnFloat != null)
            OnFloat(1.0f);


        if (OnInt != null)
            OnInt();
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            if (OnClicked != null)
                OnClicked();


            if (OnInt != null)
                OnInt();

            //doSomething.Invoke(); 
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 50, 200, 100, 30), "ClickFloat"))
        {


            if (OnFloat != null)
                OnFloat(1.0f);


         
        }
    }



}