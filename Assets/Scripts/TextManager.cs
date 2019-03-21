using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextManager : MonoBehaviour
{
    public Text text;
    public GameObject currentstate;
    public CurrentState.State cState;

    void Start()
    {
        cState = currentstate.GetComponent<CurrentState>().state;
        text.text = "";
    }

    void Update()
    {
        switch (cState)
        {
            case CurrentState.State.Start:
                text.text = "...";
                break;
            case CurrentState.State.Begin:
                text.text = "Bonjour voyageur...";
                break;
            case CurrentState.State.Alphabet:
                text.text = "Trouvez l'élément";
                break;
            case CurrentState.State.Question:
                text.text = "Quel est ...";
                break;

            case CurrentState.State.Intrus:
                text.text = "Trouvez l'intrus";
                break;
            case CurrentState.State.Fin:
                text.text = "Bon voyage, jeune aventurier";
                break;

            default:
                
                break;
        }
    }
}


