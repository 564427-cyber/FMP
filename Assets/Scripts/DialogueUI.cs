using UnityEngine;

[System.Serializable]
public class DialogueUI : MonoBehaviour
{
    public GameObject dialogueBox;


    public void Show()
    {
        dialogueBox.SetActive(true);
    }
    public void Hide()
    {
        dialogueBox?.SetActive(false);
    }
}
