using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    public DialogueTrigger trigger;
    public DialogueUI dialogueUI;
    public void Interact()
    {
        Debug.Log("Interact!");
        Show();
        trigger.TriggerDialogue();
    }

    public void Show()
    {
        Debug.Log("Showing dialogue UI");
        dialogueUI.Show();
    }
}
