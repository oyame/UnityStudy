using UnityEngine;
using System.Collections;

public class factry : MonoBehaviour {

    [SerializeField]
    GameObject ball;

    [SerializeField]
    float position = 1;

    // Use this for initialization
    void Start () {
        StartCoroutine(Factry());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator Factry() {

        while (true) {
            Instantiate(ball, new Vector3(Random.Range(-position, position), 30, 0), transform.rotation);
            yield return new WaitForSeconds(0.1f);
        }

    }
}
