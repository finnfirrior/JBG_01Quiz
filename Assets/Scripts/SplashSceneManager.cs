using UnityEngine;
using BensuStudio;

public class SplashSceneManager : MonoBehaviour
{
    private SceneController sceneController;
    
    void Awake()
    {
        sceneController = new SceneController();
    }
    void Start()
    {
        
        sceneController.LoadNextScene();
    }

    


}
