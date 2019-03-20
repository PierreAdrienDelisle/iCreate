using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum State
{
    Start = 0,
    Begin = 1,
    Alphabet = 2,
    Question = 3,
    Intrus = 4,
    Fin = 5
}

public class TextManager : MonoBehaviour
{
    public Text text;
    public State state;

    void Start()
    {
        state = State.Start;
        text.text = "";
    }

    void Update()
    {
        switch (state)
        {
            case State.Start:
                text.text = "...";
                break;
            case State.Begin:
                text.text = "Bonjour voyageur...";
                break;
            case State.Alphabet:
                text.text = "Trouvez l'élément";
                break;
            case State.Question:
                text.text = "Quel est ...";
                break;

            case State.Intrus:
                text.text = "Trouvez l'intrus";
                break;
            case State.Fin:
                text.text = "Bon voyage, jeune aventurier";
                break;

            default:
                
                break;
        }
    }
}


