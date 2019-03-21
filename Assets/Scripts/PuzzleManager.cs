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
    public GameObject RightHand;
    public GameObject LeftHand;

    // Start is called before the first frame update
    void Start()
    {
        cState = currentstate.state;
    }
    void Begin()
    {
        currentstate.state = CurrentState.State.Begin;
    }
    void Alphabet()
    {
        currentstate.state = CurrentState.State.Alphabet;
    }
    void Intrus()
    {
        currentstate.state = CurrentState.State.Intrus;
    }
    void Question()
    {
        currentstate.state = CurrentState.State.Question;
    }
    // Update is called once per frame
    void Update()
    {
        cState = currentstate.state;
        switch (cState){
            case CurrentState.State.Start:
                if (LeftHand.activeInHierarchy == true || RightHand.activeInHierarchy == true)
                {
                    currentstate.state = CurrentState.State.Begin;
                }
                break;
            case CurrentState.State.Begin:
                Invoke("Alphabet", 6);
                break;
            case CurrentState.State.Alphabet:
                roocoEnigma.SetActive(true);
                //Invoke("Question", 6);
                break;
            case CurrentState.State.Question:
                roocoEnigma.SetActive(false);
                girardetEnigma.SetActive(true);
                //Invoke("Intrus", 6);
                break;

            case CurrentState.State.Intrus:
                girardetEnigma.SetActive(false);
                intruderEnigma.SetActive(true);
                break;
            case CurrentState.State.Win:
                winState.SetActive(true);
                break;
            case CurrentState.State.Loose:
                looseState.SetActive(true);
                roocoEnigma.SetActive(false);
                girardetEnigma.SetActive(false);
                intruderEnigma.SetActive(false);
                winState.SetActive(false);

                break;
        }
    }
}
