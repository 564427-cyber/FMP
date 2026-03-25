using UnityEngine;

[System.Serializable]
public class DialogueUI : MonoBehaviour
{
    public GameObject dialogueBox;

    


    public void Show()
    {
        dialogueBox.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Hide()
    {
        dialogueBox?.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
