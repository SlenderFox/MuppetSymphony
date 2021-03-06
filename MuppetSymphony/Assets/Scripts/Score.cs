﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    private uint m_uiScore { get; set; }

    public void AddScore (uint pValue)
    {
        m_uiScore += pValue;
        Debug.Log(m_uiScore);
    }

    public void SubtractScore (uint pValue)
    {
        if (pValue > m_uiScore)
            m_uiScore = 0;
        else
            m_uiScore -= pValue;

        Debug.Log(m_uiScore);
    }

    // Start is called before the first frame update
    void Start ()
    {
        m_uiScore = 0;
        Debug.Log(m_uiScore);
    }

    // Update is called once per frame
    void Update ()
    {
        if (scoreText)
            scoreText.text = m_uiScore.ToString();
    }
}