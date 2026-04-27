using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCorruptCave : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(5);
    }
}
