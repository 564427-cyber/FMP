using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    public DialogueTrigger trigger;
    public DialogueUI dialogueUI;
    public void Interact()
    {
        Debug.Log("Interact!");
        Show(); // method for showing
        trigger.TriggerDialogue(); //triggers text from NPC
    }

    public void Show()
    {
        Debug.Log("Showing dialogue UI");
        dialogueUI.Show(); // shows dialogue UI
    }
}
