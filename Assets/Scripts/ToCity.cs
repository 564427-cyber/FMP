using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCity : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(3);
    }
}
