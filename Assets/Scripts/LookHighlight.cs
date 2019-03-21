using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LookHighlight : MonoBehaviour
{
    public Text text;
    public GameObject target;
    public float timeLeft = 3.0f;
    public CurrentState currentstate;
    public CurrentState.State newState;
    private bool isActive = false;
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
        timeLeft = 3.0f;
        text.text = "";
        target.SetActive(false);
    }

    void FixedUpdate()
    {
        if (isActive)
        {
            timeLeft -= Time.deltaTime;
            text.text = "" + Mathf.Round(timeLeft);
        }

        if (timeLeft < 0)
        {
            currentstate.state = newState;
            text.text = "";

        }
    }
}
