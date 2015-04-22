using UnityEngine;
using System.Collections;

public class StartGameButton : MonoBehaviour {

	public void StartGameButtonClick () {
		Time.timeScale = 1f;

		gameObject.SetActive(false);
	}
}
