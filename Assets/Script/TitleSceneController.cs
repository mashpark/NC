using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneController : MonoBehaviour {

	public void OnClickEnter()
	{
		SceneManager.LoadScene ("Lobby");
	}
}
