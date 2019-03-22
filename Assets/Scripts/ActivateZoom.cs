using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateZoom : MonoBehaviour
{
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        hand.GetComponent<Leap.Unity.PinchDetector>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
