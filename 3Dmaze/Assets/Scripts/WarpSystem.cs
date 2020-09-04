using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpSystem : MonoBehaviour
{
    public GameObject window1;
    public GameObject window2;

    public void SetWindow()
    {
        window1.SetActive(true);
        window2.SetActive(true);
    }

    public void CloseWindow()
    {
        window1.SetActive(false);
        window2.SetActive(false);
    }
}
