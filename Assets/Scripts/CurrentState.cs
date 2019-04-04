using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentState : MonoBehaviour
{
    //Contains the current state of the game

    public enum State
    {
        Start = 0,
        Begin = 1,
        Alphabet = 2,
        Question = 3,
        Intrus = 4,
        Win = 5,
        Loose = 6
    }
    public State state;

    void SetState(State newState)
    {
        state = newState;
    }

    State GetState()
    {
        return state;
    }

    // Start is called before the first frame update
    void Start()
    {
        state = State.Start;
    }

}
