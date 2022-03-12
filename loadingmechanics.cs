using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadingmechanics : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneload;
    void Start()
    {
        
    }
    private void Awake()
    {
        StartCoroutine(LoadAsynchronously());
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
    public Slider progressbar;
   
    IEnumerator LoadAsynchronously()
    {
        yield return new WaitForSeconds(5f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneload);
       
        while (!operation.isDone)
        {
            
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            Debug.Log(progress);
            progressbar.value = progress;
            yield return null;
        }
        
       
    }
}
