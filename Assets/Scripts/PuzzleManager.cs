using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public CurrentState currentstate;
    public GameObject roocoEnigma;
    public GameObject girardetEnigma;
    public GameObject intruderEnigma;
    public GameObject winState;
    public GameObject looseState;
    private CurrentState.State cState;

    // Start is called before the first frame update
    void Start()
    {
        cState = currentstate.state;
    }
    void Begin()
    {
        currentstate.state = CurrentState.State.Alphabet;
    }
    // Update is called once per frame
    void Update()
    {
        switch(cState){
            case CurrentState.State.Start:
                currentstate.state = CurrentState.State.Begin;
                break;
            case CurrentState.State.Begin:
                Invoke("Begin", 6);
                break;
            case CurrentState.State.Alphabet:
                roocoEnigma.SetActive(true);
                break;
            case CurrentState.State.Question:
                girardetEnigma.SetActive(true);
                break;

            case CurrentState.State.Intrus:
                intruderEnigma.SetActive(true);
                break;
            case CurrentState.State.Win:
                winState.SetActive(true);
                break;
            case CurrentState.State.Loose:
                looseState.SetActive(true);
                break;
        }
    }
}
