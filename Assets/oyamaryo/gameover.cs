using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "ball")
        {
            Debug.Log("gameover");
            Debug.Log("今回のスコア:" + PlayerPrefs.GetInt("Score"));
            Debug.Log("HighScore:" + PlayerPrefs.GetInt("HighScore"));

        }

        

    }
}
