using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LookHighlight : MonoBehaviour
{
    //Manage the highlight on objects at the first enigma : display new images when pointing and check answer to puzzle 2
    public Text text;
    public GameObject target;
    public float timeLeft = 3.0f;

    public CurrentState currentstate;
    public CurrentState.State newState;
    public GameObject roocoEnigma;

    public AudioSource Feedback;
    public AudioClip RightNoise;
    public AudioClip WrongNoise;

    private bool isActive = false;

    public void Start()
    {
        target.SetActive(false);
    }

    // highlight game object
    public void targetActive()
    {
        isActive = true;
        target.SetActive(true);
    }

    // disable highlight & reset timer
    public void targetFalse()
    {
        isActive = false;
        timeLeft = 3.0f;
        text.text = "";
        target.SetActive(false);
    }

    // update timer & check choice
    void Update()
    {
        if (isActive)
        {
            timeLeft -= Time.deltaTime;
            text.text = "" + Mathf.Round(timeLeft);
        }
        if (timeLeft < 0)
        {
            roocoEnigma.SetActive(false);
            if(newState == CurrentState.State.Loose)
            {
                Feedback.PlayOneShot(WrongNoise);
            }
            else
            {
                Feedback.PlayOneShot(RightNoise);
            }
            currentstate.state = newState;
            text.text = "";
        }
    }
}
