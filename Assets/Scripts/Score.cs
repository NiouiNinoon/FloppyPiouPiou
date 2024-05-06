using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI _scoreText;
    public TextMeshProUGUI _coinText;
    private int _score;
    private int _coins;
    
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _scoreText.text = _score.ToString();
        _coinText.text = _coins.ToString();
    }

    public void UpdateScore()
    {
        _score++;
        _scoreText.text = _score.ToString();
    }

    public void UpdateCoins()
    {
        _coins++;
        _coinText.text = _coins.ToString();
    }
}
