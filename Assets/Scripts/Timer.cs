using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //Manage the time left of the game and display the visual feedback

    public float timer = 300f;
    public GameObject Player;
    public CurrentState.State cState;
    public GameObject ZeroMin;
    public GameObject OneMin;
    public GameObject TwoMin;
    public GameObject ThreeMin;
    public GameObject FourMin;
    public GameObject FiveMin;


    // Start is called before the first frame update
    void Start()
    {
        cState = Player.GetComponent<CurrentState>().state;
    }

    // Update is called once per frame
    // The player loses if the enigma isn't solved in due time.
    // Otherwise, display a new bubble every minute for the next five minutes.
    void Update()
    {
        cState = Player.GetComponent<CurrentState>().state;
        if (cState == CurrentState.State.Start || cState == CurrentState.State.Win)
        {
            //Freeze timer

        }
        else
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                FiveMin.SetActive(true);
                Player.GetComponent<CurrentState>().state = CurrentState.State.Loose;
            }else if(timer < 60)
            {
                FourMin.SetActive(true);
            }
            else if (timer < 120)
            {
                ThreeMin.SetActive(true);
            }
            else if (timer < 180)
            {
                TwoMin.SetActive(true);
            }
            else if (timer < 240)
            {
                OneMin.SetActive(true);
            }
            else if (timer < 300)
            {
                ZeroMin.SetActive(true);
            }

        }
    }
}
