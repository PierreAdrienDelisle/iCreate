using Leap;
using Leap.Unity;
using System.Collections.Generic;
using UnityEngine;

public class HandRaycast : MonoBehaviour
{
    //DEPRECATED

    Hand leapHand;
    FingerModel finger;
    HandModel handModel;

    // Use this for initialization
    void Start()
    {
        handModel = GetComponent<HandModel>();
        leapHand = handModel.GetLeapHand();
        if (leapHand == null) Debug.LogError("No leap_hand founded");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        for (int i = 0; i < HandModel.NUM_FINGERS; i++)
        {
            finger = handModel.fingers[i];
            if (Physics.Raycast(finger.GetTipPosition(), fwd, out hit,10))
            {
                float distanceToGround = hit.distance;
                Debug.Log("hit something" + distanceToGround);
            }
            Debug.DrawRay(finger.GetTipPosition(), finger.GetRay().direction*10, Color.red, Time.deltaTime, true);
        }
    }
}
