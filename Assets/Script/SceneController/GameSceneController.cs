using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour {

	public void OnClickExit()
	{
		SceneManager.LoadScene ("Lobby");
	}
}
