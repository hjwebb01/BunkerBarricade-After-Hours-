using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public void Over()
    {
    SceneManager.LoadScene("gameOverScreen");
    }
}
