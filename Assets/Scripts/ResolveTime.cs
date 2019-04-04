using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolveTime : MonoBehaviour
{
    //Display the time done after winning

    public Timer time;
    public Text text;
    private int resolvetime;

    // Start is called before the first frame update
    void Start()
    {
        resolvetime = (int)time.timer;
        int min = (int)(resolvetime - time.timer) /60;
        int sec = (int)(resolvetime- time.timer) - (min * 60);
        string timeLeft = min + " min, " + sec + " secs";
        text.text = "Vous avez bravé le désert en " + timeLeft;
    }

}
