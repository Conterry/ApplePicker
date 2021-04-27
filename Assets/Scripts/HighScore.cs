using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    [SerializeField] ApplePicker picker;
    public Text scoreCounter;
    public int bestScore = 0; 
    public int Score = 0;

    void Awake()
    {
        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        {

            bestScore = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", bestScore);
    }

    private void Start()
    {
        picker.OnAppleCatch += AddScore;
    }

    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + bestScore;

        if (bestScore > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", bestScore);
        }

    }

    private void AddScore()
    {
        Score += 100;
        scoreCounter.text = "" + Score;
    }

}
