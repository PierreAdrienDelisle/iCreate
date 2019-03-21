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
                text.text = "Bienvenue voyageur, faites un geste pour commencer l'aventure";
                break;
            case CurrentState.State.Begin:
                text.text = "Te voilà dans le désert de Bou Saada. Tu dois accomplir ta quête avant la tombée de la nuit, avant que les températures ne chutent et t'emportent...";
                break;
            case CurrentState.State.Alphabet:
                text.text = "Tu dois trouver la ###. Cherche autour de toi pour trouver de quoi il s'agit.";
                break;
            case CurrentState.State.Question:
                text.text = "Le désert te fascine, comme il a subjugué de nombreux peintres. Quel élément du désert fascinait le peintre Eugène Alexis Girardet ? La khaira te guidera.";
                break;

            case CurrentState.State.Intrus:
                text.text = "Un intrus s'est glissé dans le paysage de Bou Saada. Observe le et promène toi dedans pour le trouver";
                break;
            case CurrentState.State.Win:
                text.text = "Bravo, tu as accompli la quête du désert ! Maintenant tu peux aller admirer ce tableau en chair et en os";
                break;
            case CurrentState.State.Loose:
                text.text = "Le soleil s'est couché. Tu n' as pas réussi à terminer la quête et est maintenant bloqué pour la nuit dans le désert. Tu peux tout de même te consoler en allant admirer ce tableau en chair et en os.";
                break;

            default:
                
                break;
        }
    }
}


