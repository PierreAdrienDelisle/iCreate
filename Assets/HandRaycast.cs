using Leap;
using Leap.Unity;
using System.Collections.Generic;
using UnityEngine;

public class HandRaycast : MonoBehaviour
{

    Hand leapHand;
    FingerModel finger;
    HandModel handModel;

    // Use this for initialization
    void Start()
    {
        /*Controller controller = new Controller();
        Frame frame = controller.Frame(); // controller is a Controller object
        if (frame.Hands.Count > 0)
        {
            List<Hand> hands = frame.Hands;
            leapHand = hands[0];
        }
        finger = leapHand.Fingers;
        Finger.FingerType fingerType = finger.Type;*/
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
