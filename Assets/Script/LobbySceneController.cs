using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbySceneController : MonoBehaviour {

	public void OnClickEnter()
	{
		SceneManager.LoadScene ("Game");
	}
}
