using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookHighlight : MonoBehaviour
{
    public void Start()
    {
        target.SetActive(false);
    }
    public GameObject target;
    public void targetActive()
    {
        target.SetActive(true);
    }
    public void targetFalse()
    {
        target.SetActive(false);
    }
   
}
