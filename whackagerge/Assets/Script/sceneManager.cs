using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    private AssetBundle myLoadedAssetBundle;
    int mainMenuIndex = 0;
    int optionsIndex = 1;
    int gameIndex = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadMainMenu (){
        SceneManager.LoadScene(mainMenuIndex);
    }

    public void loadOptions() {
        SceneManager.LoadScene(optionsIndex);
    }

    public void loadGame(){
        SceneManager.LoadScene(gameIndex);
    }
}
