using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class intro_animation_scene_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.Invoke(() => SceneManager.LoadScene("intro_animation_scene4"), 3f);
    }
}
