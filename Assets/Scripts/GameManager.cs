using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;
using UnityEngine.InputSystem;
using QuestionDataSO;
using BensuStudio;
using UnityEngine.UIElements;


public class GameManager : MonoBehaviour
{


    [SerializeField] private QuizDataSO QuizData;
    //[SerializeField] private int currentQuestion = 1;
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private TextMeshProUGUI[] answerUI;
    [SerializeField] private QuizDataSO[] allQuizDataSO;
    private QuizControl quizControl;
    private SceneController sceneController;
    int currentQuestionIndex = 0;


    void Awake()
    {
        sceneController = new SceneController();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DisplayQuestion();
    }

    private void TestFor()
    {
        int[] dataCollection = { 10, 12, 13, 8 };
        foreach (var angka in dataCollection)
        {
            Debug.Log($"Angka dari data collection {angka}");
        }
        Debug.Log("Loop Selesai");
    }

    private void DisplayQuestion()
    {
        if (currentQuestionIndex >= allQuizDataSO.Length)
        {
            sceneController.LoadGameOverScene();
            return;
        }
        questionText.text = allQuizDataSO[currentQuestionIndex].GetQuestion();
        int totalAnswer = allQuizDataSO[currentQuestionIndex].GetAnwsers().Length;
        string[] answers = allQuizDataSO[currentQuestionIndex].GetAnwsers();

        for (int j = 0; j < totalAnswer; j++)
        {
            answerUI[j].text = answers[j];
        }
    }

    public void CheckAnswer(int buttonIndex)
    {
        int correctAnswer = allQuizDataSO[currentQuestionIndex].GetCorrectAnswerIndex();
        if (buttonIndex == correctAnswer)
        {
            currentQuestionIndex++;
            DisplayQuestion();
        }

    }

}
