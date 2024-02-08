using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoardBehaviour : MonoBehaviour
{
    [SerializeField] private PlayerBehaviour selectedPlayer;
    [SerializeField] private GameObject selectedWonMessage;
    [SerializeField] private TextMeshProUGUI timerTextMeshPro;
    [SerializeField] private int maxScore = 10;
    private TextMeshProUGUI _textMeshPro;
    private float _timerTime;
    private int _score;
    
    // Start is called before the first frame update
    private void Start()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        _score = selectedPlayer.GetScore();
        
        _textMeshPro.text = $"Score: {_score}";
        timerTextMeshPro.text = $"{(int)_timerTime} Seconds";

        if (_score >= maxScore)
        {
            selectedWonMessage.SetActive(true);
        }
        else
        {
            _timerTime += Time.deltaTime;
        }
    }
}
