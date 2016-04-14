using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashSceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (LoadNextScene(1.0f));
	}
	
	IEnumerator LoadNextScene(float time)
	{
		yield return new WaitForSeconds (time);

		SceneManager.LoadScene ("Title");
	}
}
