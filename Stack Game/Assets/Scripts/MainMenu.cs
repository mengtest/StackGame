using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Text scoreText;

    public void ToGame()
    {
        SceneManager.LoadScene("Game");
    }
	// Use this for initialization
	private void Start () {
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
