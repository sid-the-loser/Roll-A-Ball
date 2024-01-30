using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoardBehaviour : MonoBehaviour
{
    [SerializeField] private PlayerBehaviour selectedPlayer;
    [SerializeField] private GameObject selectedWonMessage;
    private TextMeshProUGUI _textMeshPro;
    private int _maxScore = 10;
    
    // Start is called before the first frame update
    private void Start()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        int score = selectedPlayer.GetScore();
        _textMeshPro.text = $"Score: {score}";

        if (score >= _maxScore)
        {
            selectedWonMessage.SetActive(true);
        }
    }
}
