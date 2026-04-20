using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;



    private Queue<string> sentences;

    public DialogueUI dialogueUI;


    void Start()
    {
        sentences = new Queue<string>(); //creats a queue of sentences
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);

        nameText.text = dialogue.name;

        sentences.Clear(); //clears all previous sentences so when u speak u start a fresh

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
              
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

   

    public void OnContinueButtonClicked()
    {
        Debug.Log("Button was acctually pressed");
        DisplayNextSentence();

    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");
        FindFirstObjectByType<DialogueUI>().Hide();
    }
    
}
