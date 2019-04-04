using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateZoom : MonoBehaviour
{
    //Activate the gameplay feature of zooming when active
    public GameObject hand;

    // Start is called before the first frame update
    void Start()
    {
        hand.GetComponent<Leap.Unity.PinchDetector>().enabled = true;
    }

}
