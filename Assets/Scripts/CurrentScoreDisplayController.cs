using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentScoreDisplayController : MonoBehaviour
{
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Temps : " + scoreManager.CurrentScore.ToString(ScoreManager.TimeSpanStringFormat);
    }
}