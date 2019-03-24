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
    public Text countdown;
    private int previousFinger = -1;
    public float timeLeft = 5.0f;
    public CurrentState currentstate;
    public AudioSource Feedback;
    public AudioClip RightNoise;
    public AudioClip WrongNoise;

    void Start()
    {
        fingers = hand.GetComponent<Leap.Unity.ExtendedFingerDetector>();

    }
    void Update()
    {
        nbFinger = fingers.extendedCount;
        if (timeLeft < 0)
        {
            switch (nbFinger)
            {
                case 1:
                    countdown.text = "";
                    Feedback.PlayOneShot(WrongNoise);
                    currentstate.state = CurrentState.State.Loose;
                    break;

                case 2:
                    countdown.text = "";
                    Feedback.PlayOneShot(WrongNoise);
                    currentstate.state = CurrentState.State.Loose;
                    break;

                case 3:
                    countdown.text = "";
                    Feedback.PlayOneShot(RightNoise);
                    currentstate.state = CurrentState.State.Intrus;
                    break;

                default:
                    text.text = "?";
                    break;
            }
        }
        else
        {
            if (previousFinger != nbFinger)
            {
                timeLeft = 5.0f;
            }
            switch (nbFinger)
            {
                case 0:
                    previousFinger = 0;
                    countdown.text = "";
                    text.text = "";
                    break;
                case 1:
                    text.text = "Votre réponse : 1";
                    timeLeft -= Time.deltaTime;
                    countdown.text = "" + Mathf.Round(timeLeft);
                    previousFinger = 1;
                    break;

                case 2:
                    text.text = "Votre réponse : 2";
                    timeLeft -= Time.deltaTime;
                    countdown.text = "" + Mathf.Round(timeLeft);
                    previousFinger = 2;
                    break;

                case 3:
                    text.text = "Votre réponse : 3";
                    timeLeft -= Time.deltaTime;
                    countdown.text = "" + Mathf.Round(timeLeft);
                    previousFinger = 3;
                    break;

                case 4:
                    previousFinger = 4;
                    countdown.text = "";
                    text.text = "";
                    break;

                case 5:
                    previousFinger = 5;
                    countdown.text = "";
                    text.text = "";
                    break;

                default:
                    text.text = "?";
                    break;
            }
        }
        
    }
}
    
