using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public MenuManager menu;

    [SerializeField]
    private GameObject gameOverBox;
    [SerializeField]
    private GameObject mainCanvasBox;


    IEnumerator GameOverCoroutine()
    {
        yield return new WaitForSeconds(.3f);
        gameOverBox.SetActive(true);
        mainCanvasBox.SetActive(false);
        Time.timeScale = 0f;
    }

    public void GameIsOver()
    {
        StartCoroutine(GameOverCoroutine());
    }
}
