using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public Camera mainCam;
    public float facteur;
    public Vector3 pos;
    public bool isZooming = false;
    public GameObject finger;
    public Vector3 newPos;
    public Vector3 vecfingerPos;

    public void zoomIn()
    {
        Debug.Log(pos.z);
        Debug.Log("zoom in"+ (pos.z - facteur));
        newPos = new Vector3(pos.x + vecfingerPos.x, pos.y + vecfingerPos.y, pos.z - facteur);
        mainCam.transform.localPosition = newPos;
        isZooming = true;
    }

    public void zoomOut()
    {
        mainCam.transform.localPosition = pos;
        isZooming = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        pos = mainCam.GetComponent<Transform>().localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        vecfingerPos = finger.GetComponent<Transform>().position;
    }
}
