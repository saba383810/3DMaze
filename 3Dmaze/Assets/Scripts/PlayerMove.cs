using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    GameObject eventsystem;
    WarpSystem warpSystem;
    private bool windowflag;

    // Start is called before the first frame update
    void Start()
    {
        eventsystem =  GameObject.Find("EventSystem");
        warpSystem = eventsystem.GetComponent<WarpSystem>();
        windowflag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * 0.1f;
            if (windowflag == true)
            {
                windowflag = false;
                warpSystem.CloseWindow();
            }

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * 0.1f;
            if (windowflag == true)
            {
                windowflag = false;
                warpSystem.CloseWindow();
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -3, 0);
            if (windowflag == true)
            {
                windowflag = false;
                warpSystem.CloseWindow();
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 3, 0);
            if (windowflag == true)
            {
                windowflag = false;
                warpSystem.CloseWindow();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (windowflag == true)
            {
                transform.position = new Vector3(4, 0, 5);
                transform.rotation = new Quaternion(0, 180, 0, 0);
                warpSystem.CloseWindow();
                windowflag = false;
            }
            else
            {
                warpSystem.SetWindow();
                windowflag = true;
            }
        }
    }
}
