using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomChevre : MonoBehaviour
{
    //Manage the winning state if on the position of the goat
    public Camera mainCam;
    public GameObject Player;
    public CurrentState.State cState;

    public AudioSource Feedback;
    public AudioClip RightNoise;
    public AudioClip WrongNoise;

    public float Xmax = -2.35f;
    public float Xmin = -2.45f;
    public float Ymax = 1f;
    public float Ymin = 0.89f;

    private float camX;
    private float camY;


    // Start is called before the first frame update
    void Start()
    {
        cState = Player.GetComponent<CurrentState>().state;
    }

    // Update is called once per frame
    // Checks if you have correctly zoomed on the goat
    void Update()
    {
        camX = mainCam.transform.localPosition.x;
        camY = mainCam.transform.localPosition.y;

        if (camX<Xmax &&  camX > Xmin && camY < Ymax && camY > Ymin)
        {
            Feedback.PlayOneShot(RightNoise);
            Player.GetComponent<CurrentState>().state = CurrentState.State.Win;
            Debug.Log("CHEEEVRE");
        }
    }
}
