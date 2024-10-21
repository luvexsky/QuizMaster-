using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.Unity.VisualStudio.Editor;
using System;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questiontext;
   [SerializeField] QuestionSO question;
   [SerializeField] GameObject[] answerButtons;
   int correctanswerindex;
   [SerializeField] Sprite defaultAnswerSprite;
   [SerializeField] Sprite correctAnswerSprite;
    void Start()
    {
        questiontext.text = question.GetQuestion();

for(int i = 0; i < answerButtons.Length; i++)
{
        TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
        buttonText.text = question.GetAnswer(i);
}
    }

   public void OnAnswerSelected(int index)
{ 
    if (index == question.GetCorrectAnswerIndex())
    { 
        questiontext.text = "Correct!";
        Image buttonImage = answerButtons[index].GetComponent<Image>();
        buttonImage.Sprite = correctAnswerSprite;
    }
    
}

    
}