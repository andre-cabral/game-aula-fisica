using UnityEngine;
using System.Collections;

public class PlayerCollideWin : MonoBehaviour {

	public GameObject textoWin;
	public GameObject buttonRestart;

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Flag"){
			textoWin.SetActive(true);
			buttonRestart.SetActive(true);
			Time.timeScale = 0f;
		}
	}
}
