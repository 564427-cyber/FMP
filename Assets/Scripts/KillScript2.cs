using UnityEngine;
using UnityEngine.SceneManagement;

public class KillScript2 : MonoBehaviour
{
    public void KillPlayer2()
    {
        SceneManager.LoadScene(5);
        Debug.Log("Player Dead");
    }


}
