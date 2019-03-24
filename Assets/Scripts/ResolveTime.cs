using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolveTime : MonoBehaviour
{
    public Timer time;
    public Text text;
    public int resolvetime = 300;
    // Start is called before the first frame update
    void Start()
    {
        int min = (int)(resolvetime - time.timer) /60;
        int sec = (int)(resolvetime- time.timer) - (min * 60);
        string timeLeft = min + " min, " + sec + " secs";
        text.text = "Vous avez bravé le désert en " + timeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
