using UnityEngine;
using UnityEngine.SceneManagement;

public class KillScript : MonoBehaviour
{
    public void KillPlayer()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Player Dead");
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(0);
        Debug.Log("player Dead");
    }
}

