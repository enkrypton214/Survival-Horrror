
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMenu : MonoBehaviour
{ 
    string newGameScene = "MainGame";
    [SerializeField] AudioSource bgkMusic;

    public void Start()
    {
        bgkMusic.Play();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void StartNewGame()
    {
        bgkMusic.Stop();
        SceneManager.LoadScene(newGameScene);
    }
    public void ExitApplication()
    {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;

#else
        Application.Quit();
#endif
    }
}
