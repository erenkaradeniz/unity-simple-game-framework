﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    public void NextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (PlayerPrefs.GetInt("levelReached", 1) < nextSceneIndex)
        {
            PlayerPrefs.SetInt("levelReached", nextSceneIndex);
        }

        SceneManager.LoadScene(nextSceneIndex);
    }
}