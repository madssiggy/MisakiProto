﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title: MonoBehaviour
{
    [SerializeField]

    Fade fade = null;



    public void FadeOut()
    {
        //fade.FadeIn (1, () => {

        //	fade.FadeOut (1);

        //});

        fade.FadeIn(1, () =>
        {
            Invoke("LoadScene", 0.5f);
        });
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("LevelScene");
    }


}
