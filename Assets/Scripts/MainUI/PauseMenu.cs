using Unity.Cinemachine;
using UnityEditor.Search;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    
    bool isShown = false;

    private void Start()
    {
        Hide();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isShown)
            {
                Hide();
            }
            else
            {
                Show();
            }

            isShown = !isShown;
        }
    }


    private void Show()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    private void Hide()
    {
        pauseMenu?.SetActive(false);
        Time.timeScale = 1.0f;
        
    }
}

