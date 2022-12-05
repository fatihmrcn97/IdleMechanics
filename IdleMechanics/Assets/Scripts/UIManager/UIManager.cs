using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public static UIManager instance;
    private void Awake()
    {
        instance = this;
    }

    [SerializeField] private TextMeshProUGUI scoreText;
    public int score;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("score")) PlayerPrefs.SetInt("score", 0);
        else score = PlayerPrefs.GetInt("score");
        scoreText.text = score.ToString();
    }


    public void AddScore(int a)
    {
        score += a;
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt("score", score);
    }


} 