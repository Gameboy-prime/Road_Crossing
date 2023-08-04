using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    public Slider slider;

    private float value;

    public GameObject loadBox;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    
    public void LoadScene()
    {
        StartCoroutine(LoadSceneAsynchronously());

    }
    IEnumerator LoadSceneAsynchronously()
    {
        loadBox.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);
        while (!operation.isDone)
        {
            value = Mathf.Clamp01(operation.progress/0.9f);
            Debug.Log(value);
            
            slider.value = value;
            yield return null;

        }

    }
}

