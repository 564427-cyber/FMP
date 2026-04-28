using UnityEngine;
using UnityEngine.SceneManagement;

public class KillScript : MonoBehaviour
{
    public void KillPlayer()
    {
        SceneManager.LoadScene(4);
        Debug.Log("Player Dead");
    }

   
}

