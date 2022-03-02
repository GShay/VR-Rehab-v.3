using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI pointsText;
    public int points = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        pointsText.text = points.ToString() + " Block(s)";
    }

    public void AddPoint()
    {
        points += 1;
        pointsText.text = points.ToString() + " Blocks";
    }
}
