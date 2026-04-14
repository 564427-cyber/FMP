using UnityEngine;

public class CanvasShow : MonoBehaviour
{
    public GameObject UICanvas;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered with: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entred");
            UICanvas.SetActive(true);
        }
    }
}
