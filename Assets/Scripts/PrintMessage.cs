using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintMessage : MonoBehaviour
{
    //Testing class to print message according to leap motion events

    public void PrintActivateMessage()
    {
        print("Extended finger Activated");
    }
    public void PrintDeactivateMessage()
    {
        print("Extended finger Deactivated");
    }
    public void PalmDown()
    {
        print("PalmDown");
    }
    public void PalmUp()
    {
        print("PalmUp");
    }
    public void PinchActivate()
    {
        print("PinchActivate");
    }
    public void PinchDeactivate()
    {
        print("PinchDeactivate");
    }
    public void FingerDirActivate()
    {
        print("FingerDirActivate");
    }
    public void FingerDirDeactivate()
    {
        print("FingerDirDeactivate");
    }
    public void ProximityActivate()
    {
        print("ProximityActivate");
    }
    public void ProximityDeactivate()
    {
        print("ProximityDeactivate");
    }
}
