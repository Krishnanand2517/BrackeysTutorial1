using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;

	public float initPos;
	
	void Start() {
		initPos = player.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = (player.position.z - initPos).ToString("0");
	}
}
