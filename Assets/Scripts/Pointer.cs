using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * -10, Color.red);
        if(Physics.Raycast(transform.position,transform.forward * -1, out hit, 10))
        {
			Debug.Log("Le raycast touche un objet !");
            Debug.Log(hit.transform.tag);
            if (hit.transform.tag == "Ane")
            {
                Debug.Log("Un ANE ! ");
            }
        }
    }
}
