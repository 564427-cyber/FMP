using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameComplete : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(7);
    }
}
