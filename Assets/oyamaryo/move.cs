using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    [SerializeField]
    float speed = 0.2f;

    int count = 0;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("Score", count);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed,0, 0));
	}

    void OnCollisionEnter(Collision other) {

        if (other.gameObject.tag == "ball") {
            //Debug.Log("ボールだから消すよ");

            count++;

            PlayerPrefs.SetInt("Score", count);

            if (PlayerPrefs.GetInt("HighScore") < count) {
                PlayerPrefs.SetInt("HighScore", count);
            }

            Destroy(other.gameObject);
        }

    }
    
}
