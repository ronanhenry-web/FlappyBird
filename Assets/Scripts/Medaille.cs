using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Medaille : MonoBehaviour
{
    public GameObject bronzeMedal;
    public GameObject silverMedal;
    public GameObject goldMedal;
    public int score;

    public void OnPlayerDeath()
    {
        Debug.Log("OnPlayerDeath called, displaying medals.");
        DisplayMedals();
    }

    private void DisplayMedals()
    {
        Debug.Log("DisplayMedals: Score is " + score);
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
