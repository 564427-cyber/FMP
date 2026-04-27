using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCorruptCity : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(6);
    }
}
