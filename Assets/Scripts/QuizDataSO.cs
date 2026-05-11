namespace QuestionDataSO
{

    using UnityEngine;

    [CreateAssetMenu(fileName = "QuizDataSO", menuName = "Scriptable Objects/QuizDataSO")]
    public class QuizDataSO : ScriptableObject
    {
        [TextArea(3, 8)][SerializeField] private string question;
        [SerializeField] private string[] answers;
        [SerializeField] private int correctAnswer;

        public string GetQuestion()
        {
            return question;
        }


        public string[] GetAnwsers()
        {
            return answers;
        }

        public int GetCorrectAnswerIndex()
        {
            return correctAnswer;
        }
    }
}