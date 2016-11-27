using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	float raptime = 0;
	public UnityEngine.UI.Text raptimeLabel;
	// Update is called once per frame
	void Update () {
		raptime += Time.deltaTime;
		string minutes = Mathf.FloorToInt (raptime / 60).ToString("00");
		string seconds = Mathf.FloorToInt (raptime % 60).ToString("00");
		string nseconds = Mathf.FloorToInt ((raptime * 1000)  % 1000).ToString("00");
		raptimeLabel.text = minutes + ":" + seconds + ":" + nseconds;
	}
}
