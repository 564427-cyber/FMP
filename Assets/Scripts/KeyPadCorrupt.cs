using System.Collections;
using TMPro;
using UnityEngine;

public class KeyPadCorrupt : MonoBehaviour
{
    public TMP_InputField charHolder;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;
    public GameObject clearButton;
    public GameObject enterButton;


    public GameObject keypadUI;
    public GameObject door;

    private void Start()
    {
        Hide();
    }

    private void Update()
    {
        if(charHolder.text == "FAILED")
        {
            charHolder.text = null;
        }
    }

   



    public void Show()
    {
        keypadUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Hide()
    {
        keypadUI?.SetActive(false);
        Time.timeScale = 1.0f;
    }

    private void OnMouseDown()
    {
        Show();
    }

    public void B1()
    {
        charHolder.text += "1";
    }
    public void B2()
    {
        charHolder.text += "2";
    }
    public void B3()
    {
        charHolder.text += "3";
    }
    public void B4()
    {
        charHolder.text += "4";
    }
    public void B5()
    {
        charHolder.text += "5";
    }
    public void B6()
    {
        charHolder.text += "6";
    }
    public void B7()
    {
        charHolder.text += "7";
    }
    public void B8()
    {
        charHolder.text += "8";
    }
    public void B9()
    {
        charHolder.text += "9";
    }
    public void B0()
    {
        charHolder.text += "0";
    }
    public void ClearEvent()
    {
        charHolder.text = null;
    }
    public void EnterEvent()
    {

        if (charHolder.text == "522912")
        {
            Debug.Log("Success");
            Hide();
            Destroy(door);

        }
        else
        {
            Debug.Log("Failed");
            charHolder.text = "FAILED";
        }
    }
}

