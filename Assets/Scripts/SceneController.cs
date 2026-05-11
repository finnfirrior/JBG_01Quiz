namespace BensuStudio
{
    using UnityEngine;
    using UnityEngine.Rendering;
    using UnityEngine.SceneManagement;
    public class SceneController
    {

        [SerializeField] private string sceneName;
        // Start is called once before the first execution of Update after the MonoBehaviour is created


        public void LoadNextScene()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }

        public void LoadGameOverScene()
        {
            SceneManager.LoadScene("Game Over Scene");
        }
        public void LoadSceneByName(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
