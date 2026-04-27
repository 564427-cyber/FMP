using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCorruptForest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(4);
    }
}
