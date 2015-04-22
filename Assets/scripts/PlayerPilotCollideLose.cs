using UnityEngine;
using System.Collections;

public class PlayerPilotCollideLose : MonoBehaviour {

	public GameObject textoLose;
	public GameObject buttonRestart;

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Floor"){
			textoLose.SetActive(true);
			buttonRestart.SetActive(true);
			Time.timeScale = 0f;
		}
	}
}
