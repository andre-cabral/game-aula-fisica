using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text textNumber;
	public float timer = 30f;
	public GameObject textoLose;
	public GameObject buttonRestart;

	void Awake () {
		textNumber.text = Mathf.RoundToInt(timer).ToString();
		Time.timeScale = 0f;
	}

	void Update () {
		timer -= Time.deltaTime;
		textNumber.text = Mathf.RoundToInt(timer).ToString();

		if(Mathf.RoundToInt(timer) <= 0){
			textoLose.SetActive(true);
			buttonRestart.SetActive(true);
			Time.timeScale = 0f;
		}
	}
}
