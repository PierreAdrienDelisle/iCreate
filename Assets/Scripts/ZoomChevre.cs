using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomChevre : MonoBehaviour
{
    public Camera mainCam;
    public GameObject Player;
    public CurrentState.State cState;
    public float Xmax = -2.3f;
    public float Xmin = -2.65f;
    public float Ymax = 1f;
    public float Ymin = 0.89f;
    public float camX;
    public float camY;
    // Start is called before the first frame update
    void Start()
    {
        cState = Player.GetComponent<CurrentState>().state;
    }

    // Update is called once per frame
    void Update()
    {
        camX = mainCam.transform.localPosition.x;
        camY = mainCam.transform.localPosition.y;

        if (camX<Xmax &&  camX > Xmin && camY < Ymax && camY > Ymin)
        {
            Player.GetComponent<CurrentState>().state = CurrentState.State.Win;
            Debug.Log("CHEEEVRE");
        }
    }
}
