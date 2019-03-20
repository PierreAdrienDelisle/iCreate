/******************************************************************************
 * Copyright (C) Leap Motion, Inc. 2011-2018.                                 *
 * Leap Motion proprietary and confidential.                                  *
 *                                                                            *
 * Use subject to the terms of the Leap Motion SDK Agreement available at     *
 * https://developer.leapmotion.com/sdk_agreement, or another agreement       *
 * between Leap Motion and you, your company or other organization.           *
 ******************************************************************************/

using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class NumberFingers : MonoBehaviour
{
    public GameObject hand;
    public int nbFinger;
    public Leap.Unity.ExtendedFingerDetector fingers;
    public bool isNumber=false;
    public Text text;

    void Start()
    {
        fingers = hand.GetComponent<Leap.Unity.ExtendedFingerDetector>();

    }
    void Update()
    {
        nbFinger = fingers.extendedCount;
        switch(nbFinger)
           {
            case 0:
                text.text = "0";
                break;
            case 1:
                text.text = "1";
            break;

            case 2:
                text.text = "2";
                break;

            case 3:
                text.text = "3";
                break;

            case 4:
                text.text = "4";
                break;

            case 5:
                text.text = "5";
                break;

            default:
                text.text = "?";
                break;
        }
    }
}
    
