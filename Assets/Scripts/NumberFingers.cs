using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class NumberFingers : MonoBehaviour
{
    // Manages the gameplay feature : fingers count and recognizing a number
    // recognizes the numbers 1, 2 and 3 only
    public GameObject hand;
    public int nbFinger;
    public Leap.Unity.ExtendedFingerDetector fingers;
    public bool isNumber=false;

    public Text text;
    public Text countdown;
    public CurrentState currentstate;

    public AudioSource Feedback;
    public AudioClip RightNoise;
    public AudioClip WrongNoise;

    private int previousFinger = -1;
    private float timeLeft = 3.0f;

    void Start()
    {
        fingers = hand.GetComponent<Leap.Unity.ExtendedFingerDetector>();
    }
    void Update()
    {
        // the answer will not be checked if it isn't stable during 3 seconds
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
                    // 3 is the correct answer to the question
                    countdown.text = "";
                    Feedback.PlayOneShot(RightNoise);
                    currentstate.state = CurrentState.State.Intrus;
                    break;

                default:
                    // the number isn't recognized
                    text.text = "?";
                    break;
            }
        }
        else
        {
            if (previousFinger != nbFinger)
            {
                // reset time
                timeLeft = 3.0f;
            }
            switch (nbFinger)
            {
                // update time countdown
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
    
