using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour
{
    public bool isGetItem = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("isGetItem :" + isGetItem);
        }
    }
	private void OnCollisionEnter(Collision col)
	{
        if (col.gameObject.tag == "KeyItem")
        {
            isGetItem = true;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "BrokenWall" && isGetItem == true)
        {
            Destroy(col.gameObject);
        }
	}
}
