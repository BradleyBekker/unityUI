using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {

    private int Score = 0;
    public Text text;

    // Use this for initialization
    void Start () {
        text.text = "score:" + Score.ToString();
    }
	
    public void AddScore()
    {
        Score++ ;
        text.text = "score:" + Score.ToString();
    }
    public void DeductScore()
    {
        if (Score > 0) {
            Score--;
            text.text = "score:" + Score.ToString();
        }
        }
}
