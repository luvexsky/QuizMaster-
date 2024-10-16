using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questiontext;
   [SerializeField] QuestionSO question;
   [SerializeField] GameObject[] answerButtons;
    void Start()
    {
        questiontext.text = question.GetQuestion();

        TextMeshProUGUI buttonText = answerButtons[0].GetComponentInChildren<TextMeshProUGUI>();
        buttonText.text = question.GetAnswer(0);
    }
}