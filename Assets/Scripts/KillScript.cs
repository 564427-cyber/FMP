using UnityEngine;
using UnityEngine.SceneManagement;

public class KillScript : MonoBehaviour
{
    public void KillPlayer()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Player Dead");
    }

   
}

