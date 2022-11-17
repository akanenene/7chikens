using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAsobu : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("MainGame", LoadSceneMode.Single);
    }
}
