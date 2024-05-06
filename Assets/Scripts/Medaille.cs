using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Medaille : MonoBehaviour
{
    public GameObject canvas;
    public GameObject bronzeMedal;
    public GameObject silverMedal;
    public GameObject goldMedal;
    public int score;

    void Start()
    {
        canvas.SetActive(false);
    }

    public void OnPlayerDeath()
    {
        DisplayMedals();
    }

    private void DisplayMedals()
    {
        canvas.SetActive(true);

        goldMedal.SetActive(false);
        silverMedal.SetActive(false);
        bronzeMedal.SetActive(false);

        if (score >= 1 && score < 20)
        {
            bronzeMedal.SetActive(true);
        }
        else if (score >= 20 && score < 30)
        {
            silverMedal.SetActive(true);
        }
        else if (score >= 30)
        {
            goldMedal.SetActive(true);
        }
    }
}
