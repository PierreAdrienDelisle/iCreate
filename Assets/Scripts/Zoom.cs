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
    public float baseX;
    public float baseY;
    public float diffY;
    public float diffX;
    public float diffFacteurX=20.0f;
    public float diffFacteurY = 20.0f;

    public void zoomIn()
    {
        diffY = baseY - vecfingerPos.y;
        diffX = baseX - vecfingerPos.x;
        newPos = new Vector3(pos.x - diffFacteurX * diffX, pos.y - diffFacteurY * diffY, pos.z - facteur);
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
        if(baseX == 0)
        {
            baseX = vecfingerPos.x;
            baseY = vecfingerPos.y;
        }
        vecfingerPos = finger.GetComponent<Transform>().position;
        if (isZooming)
        {
            diffY = baseY - vecfingerPos.y;
            diffX = baseX - vecfingerPos.x;
            newPos = new Vector3(pos.x - diffFacteurX * diffX, pos.y - diffFacteurY * diffY, pos.z - facteur);
            mainCam.transform.localPosition = newPos;
        }
    }
}
