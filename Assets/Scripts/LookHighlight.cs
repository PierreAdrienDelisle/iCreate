using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LookHighlight : MonoBehaviour
{
    public Text text;
    public GameObject target;
    public float timeLeft = 5.0f;
    public CurrentState currentstate;
    public CurrentState.State newState;
    public GameObject roocoEnigma;
    private bool isActive = false;
    public AudioSource Feedback;
    public AudioClip RightNoise;
    public AudioClip WrongNoise;

    public void Start()
    {
        target.SetActive(false);
    }

    public void targetActive()
    {
        isActive = true;
        target.SetActive(true);
    }

    public void targetFalse()
    {
        isActive = false;
        timeLeft = 5.0f;
        text.text = "";
        target.SetActive(false);
    }

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
