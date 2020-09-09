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
        warpSystem.CloseWindow();
        windowflag = false;
    }

    // Update is called once per frame
    void Update()
    {
        //上向矢印キーが押されたら前へ進む
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += transform.forward * 0.3f;
            }
            else
            {
                transform.position += transform.forward * 0.1f;
            }

    
            if (windowflag == true)
            {
                windowflag = false;
                warpSystem.CloseWindow();
            }
        }

        //下向矢印キーが押されたら後ろに下がる
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position -= transform.forward * 0.3f;
            }
            else
            {
                transform.position -= transform.forward * 0.1f;
            }

            if (windowflag == true)
            {
                windowflag = false;
                warpSystem.CloseWindow();
            }
        }

        //左向矢印キーが押されたら左向きに回る
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -3, 0);
            if (windowflag == true)
            {
                windowflag = false;
                warpSystem.CloseWindow();
            }
        }

        //右向矢印キーが押されたら右向きに回る
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 3, 0);
            if (windowflag == true)
            {
                windowflag = false;
                warpSystem.CloseWindow();
            }
        }
        //spaceキーが押されたらワープするか聞く。
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
