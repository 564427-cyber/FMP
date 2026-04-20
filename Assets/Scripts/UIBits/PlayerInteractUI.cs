using UnityEngine;

public class PlayerInteractUI : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerInteract playerInteract;
    // E interact button
    private void Update()
    {
        if (playerInteract.GetInteractableObject() != null)
        {
            Show(); //shows interact button
        }
        else
        {
            Hide(); //hide interact button when not in range of NPC
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Hide(); // Hide interact button
        }
                
    }
    private void Show()
    {
        containerGameObject.SetActive(true);
    }

    private void Hide()
    {
        containerGameObject?.SetActive(false);
    }
}
