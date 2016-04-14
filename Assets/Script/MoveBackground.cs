using UnityEngine;
using System.Collections;

public class MoveBackground : MonoBehaviour {
	public UISprite	back_0;
	public UISprite back_1;

	// Update is called once per frame
	void Update () {
		
		back_0.transform.Translate(-0.01f, 0, 0);
		back_1.transform.Translate(-0.01f, 0, 0);

		if (back_0.transform.localPosition.x < -469.0f) 
		{
			back_1.transform.localPosition = new Vector3 (1580.0f, 0, 0);
		}

		if(back_1.transform.localPosition.x < -469.0f)
			back_0.transform.localPosition = new Vector3 (1580.0f, 0, 0);
	}
}
