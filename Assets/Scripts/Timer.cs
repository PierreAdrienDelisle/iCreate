using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 300f;
    public GameObject Player;
    public CurrentState.State cState;
    // Start is called before the first frame update
    void Start()
    {
        cState = Player.GetComponent<CurrentState>().state;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Player.GetComponent<CurrentState>().state = CurrentState.State.Loose;
        }
    }
}
