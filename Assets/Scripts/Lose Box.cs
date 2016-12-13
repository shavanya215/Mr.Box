using UnityEngine;
using System.Collections;

public class LoseBox : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Player").SendMessage("Finished");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
