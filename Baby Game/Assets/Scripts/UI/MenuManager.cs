using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public static bool isPause;
    [SerializeField] private GameObject gameoverBox;

    [SerializeField] private GameObject pauseBox;

    [SerializeField] private GameObject quitBox;
    [SerializeField] private GameObject mainCanvasBox;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void PauseGame()
    {
        StartCoroutine(Pause());

    }

    public void ResumeGame()
    {
        StartCoroutine(Resume());
    }

    IEnumerator Pause()
    {
        isPause = true;
        pauseBox.SetActive(true);
        mainCanvasBox.SetActive(false);
        yield return  new WaitForSeconds(.21f);
        Time.timeScale = 0f;
    }
    
    IEnumerator Resume()
    {
        isPause = false;
        Time.timeScale = 1f;
        mainCanvasBox.SetActive(true);
        pauseBox.SetActive(false);
        
        yield return  new WaitForSeconds(0.1f);
        
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void QuitMenu()
    {
        quitBox.SetActive(true);
        pauseBox.SetActive(false);
    }

    public void DeactivateQuitMenu()
    {
        pauseBox.SetActive(true);
        quitBox.SetActive(false);
    }

    public void LoadMainMenu()
    {
        isPause = false;
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        
    }

    
}
