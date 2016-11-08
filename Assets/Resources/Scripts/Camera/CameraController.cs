using UnityEngine;
using System.Collections;

//CameraController.cs
//Author(s): Michal Jez
//Shadowstruck Software

//Used to naviguate through the map without the camera being bound to a Player

public class CameraController : MonoBehaviour
{
    private float x, y, z;

    private bool wDown, aDown, sDown, dDown;

    private bool pressedDown, mapControl;

    private float vx, vy, maxV = 0.5f, acc = 0.01f;

    private float viewSize, vs = 0.0f;

    public GameObject player;

    public float smoothTimeY;
    public float smoothTimeX;

	// Use this for initialization
	void Start ()
    {
        //Starts at origin
        x = 0f;
        y = 0f;
        z = -10f;
        transform.position = new Vector3(x, y, z);

        viewSize = 5.0f;
        Camera.main.orthographicSize = viewSize;
        player = GameObject.FindGameObjectWithTag("Player");
        mapControl = true;
    }
	
	// Update is called once per frame
	void Update ()
    {

        bool playerSwitch = Input.GetKey(KeyCode.P);
        if(playerSwitch && !pressedDown)
        {
            mapControl = !mapControl;
            pressedDown = true;
        }
        if (!playerSwitch)
        {
            pressedDown = false;
        }
        //Updates the camera based on user input
        if (mapControl)
        {
            UpdateX();
            UpdateY();
            UpdateViewSize();
        }
        else
        {
            UpdatePlayerView();
            Camera.main.orthographicSize = 5.0f;
        
        }
        
        transform.position = new Vector3(x, y, z);
    }

    private void UpdatePlayerView()
    {
        //smoothly transitions the coordinates from where the camera was to the new camera position (player coordinate)
        x = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref maxV, smoothTimeX);
        y = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref maxV, smoothTimeY);
    }

    private void UpdateX()
    {   
        //Updates the X-coordinate

        //True if the key is pressed
        bool a = Input.GetKey(KeyCode.A);
        bool d = Input.GetKey(KeyCode.D);

        if (a)
        {
            //If the A key is pressed it accelerates left until it reaches its terminal velocity
            vx -= acc;
            if (vx < -maxV)
                vx = -maxV;
        }
        if (d)
        {
            //If the D key is pressed it accelerates right until it reaches its terminal velocity
            vx += acc;
            if (vx > maxV)
                vx = maxV;
        }
        if (!a && !d && vx != 0.0f)
        {
            //If neither key is pressed the camera is still moving it slows down
            vx += (vx > 0.0f) ? -acc : acc;

            if (-0.1 < vx && vx < 0.1)
                vx = 0.0f;
        }

        //Increases the x-coordinate by the current velocity
        x += vx;
    }

    private void UpdateY()
    {   
        //Updates the Y-coordinate

        //True if the key is pressed
        bool s = Input.GetKey(KeyCode.S);
        bool w = Input.GetKey(KeyCode.W);

        if (s)
        {
            //If the A key is pressed it accelerates left until it reaches its terminal velocity
            vy -= acc;
            if (vy < -maxV)
                vy = -maxV;
        }
        if (w)
        {
            //If the D key is pressed it accelerates right until it reaches its terminal velocity
            vy += acc;
            if (vy > maxV)
                vy = maxV;
        }
        if (!s && !w && vy != 0.0f)
        {
            //If neither key is pressed the camera is still moving it slows down
            vy += (vy > 0.0f) ? -acc : acc;

            if (-0.1 < vy && vy < 0.1)
                vy = 0.0f;
        }

        //Increases the y-coordinate by the current velocity
        y += vy;
    }

    private void UpdateViewSize()
    {
        //Updates the camera view size
        //Gives the effect of zooming in or out
        //Controlled using UpArrow and DownArrow

        //True if the key is pressed
        bool u = Input.GetKey(KeyCode.UpArrow);
        bool d = Input.GetKey(KeyCode.DownArrow);

        if (u)
        {
            //If the UpArrow key is pressed it accelerates inwards until it reaches its terminal velocity
            vs -= acc;
            if (vs < -maxV)
                vs = -maxV;
        }
        if (d)
        {
            //If the DownArrow key is pressed it accelerates outwards until it reaches its terminal velocity
            vs += acc;
            if (vs > maxV)
                vs = maxV;
        }
        if (!u && !d && vs != 0.0f)
        {
            //If neither key is pressed the camera is still moving it slows down
            vs += (vs > 0.0f) ? -acc : acc;

            if (-0.1 < vs && vs < 0.1)
                vs = 0.0f;
        }

        //Increases the size by the current velocity
        viewSize += vs;
        if (viewSize < 0.01f)
            viewSize = 0.01f;
        Camera.main.orthographicSize = viewSize;
    }
}