using UnityEngine;
using UnityEngine.UI;
using System;
public class UILogic : MonoBehaviour
{
    public Text text;
    public string processedText;
    public InputField input;

    public void getInput()
    
    {
        processText(input.textComponent.text);
    }
    public void displayOutput()
    {
        Debug.Log(processedText);
        double avg = InputHandler.getAverageChars(this.processedText);
        text.text = avg.ToString();
    }
    public void processText(string inS)
    {
        Debug.Log("Before input handler: " + inS);
        //this.processedText = inS;
        this.processedText = InputHandler.processText(inS);
        displayOutput();
    }

}
