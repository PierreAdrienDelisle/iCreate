using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    //Switch active container according to the current state
    public CurrentState currentstate;
    public GameObject roocoEnigma;
    public GameObject girardetEnigma;
    public GameObject intruderEnigma;
    public GameObject winState;
    public GameObject looseState;
    public GameObject WaitingScreen;
    public GameObject BeginScreen;

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
    void BeginAct()
    {
        BeginScreen.SetActive(false);
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    // Update is called once per frame
    void Update()
    {
        cState = currentstate.state;
        switch (cState){
            case CurrentState.State.Start:
                if (LeftHand.activeInHierarchy == true || RightHand.activeInHierarchy == true)
                {
                    WaitingScreen.SetActive(false);
                    currentstate.state = CurrentState.State.Begin;
                }
                break;
            case CurrentState.State.Begin:
                BeginScreen.SetActive(true);
                Invoke("BeginAct", 6);
                Invoke("Alphabet", 6);
                break;
            case CurrentState.State.Alphabet:
                BeginScreen.SetActive(false);
                roocoEnigma.SetActive(true);
                break;
            case CurrentState.State.Question:
                roocoEnigma.SetActive(false);
                girardetEnigma.SetActive(true);
                break;

            case CurrentState.State.Intrus:
                girardetEnigma.SetActive(false);
                intruderEnigma.SetActive(true);
                break;
            case CurrentState.State.Win:
                intruderEnigma.SetActive(false);
                winState.SetActive(true);
                Invoke("ReloadScene", 20);
                break;
            case CurrentState.State.Loose:
                looseState.SetActive(true);
                roocoEnigma.SetActive(false);
                girardetEnigma.SetActive(false);
                intruderEnigma.SetActive(false);
                winState.SetActive(false);
                Invoke("ReloadScene", 20);
                break;
        }
    }
}
