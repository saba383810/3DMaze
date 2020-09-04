using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


	private void OnCollisionEnter(Collision col)
	{
        if (col.gameObject.tag == "Goal1")
        {
            Debug.Log("次のステージへ！");
            SceneManager.LoadScene("nextStage");
        }
	}
}
