namespace Examination_System
{
    abstract class Question
    {
        Question Question1 { get; set; }
        public abstract string DisplayQuestion();
        public string Body { get; set; }
        public int Mark { get; set; }
        public string Header { get; set; }
    }
    class TrueFalseQuestion : Question
    {
        public string result { get; set; }

        public override string DisplayQuestion()
        {
            return $"Question : {Body}  , Mark: {Mark}";

        }
    }

    class ChooseOneQuestion : Question
    {
        public override string DisplayQuestion()
        {
            return ($"Question : {Body}");
            Console.WriteLine("Enter your Answer");
            string yourAnswer = Console.ReadLine();
        }
    }

    class ChooseAllQuestion : Question
    {

        public override string DisplayQuestion()
        {
            return ($"Question : {Body}");
        }
    }
    class Answer
    {
        string Text { get; set; }
        bool IsCorrect { get; set; }
        public void CrrectAnswer()
        {
            Console.Write("True Answer : ");
            string answers = Console.ReadLine();
        }
    }
    class QuestionList
    {
        Question[] questions;
        private int index = 0;
        public QuestionList(int size)
        {
            questions = new Question[size];
        }
        public void AddQuestion(Question question1)
        {
            if (index < questions.Length)
            {
                questions[index] = question1;
                index++;
            }
            else
            {
                Console.WriteLine("No more space for questions!");
            }
        }

        public void DisplayAllQuestions()
        {
            for (int i = 0; i < index; i++)
            {
                questions[i].DisplayQuestion();
            }
        }
    }

    class AnswerList
    {
        Answer[] answers;
        private int index = 0;
        public AnswerList(int size)
        {
            answers = new Answer[size];
        }
        public void AddAnswer(Answer answer)
        {
            if (index < answers.Length)
            {
                answers[index] = answer;
                index++;
                Console.WriteLine("Answer added successfully! \n");
            }
            else
            {
                Console.WriteLine("No more space for answers!");
            }
        }
    }
    class Subject
    {
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
    }

    abstract class Exam
    {
        public TimeSpan Duration { get; set; }
        public int NumberOfQuestions { get; set; }
        public Dictionary<Question, Answer> QuestionAnswerMap { get; set; }
        public Subject RelatedSubject { get; set; }

        public abstract void ShowExam();
    }

    class FinalExam : Exam
    {
        public string FinalSubjectName { get; set; }
        public override void ShowExam()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            for (int j = 0; j >= input; j++)
            {
                Console.WriteLine("1. Are you Instractor");
                Console.WriteLine("2. Are you Studeny");
                Console.WriteLine("Chooce between number (1 - 2)");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("How many Qusetion you want? ");
                        input = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < input; i++)
                        {
                            Console.WriteLine("1. True/False Question");
                            Console.WriteLine("2. Choose One Question");
                            Console.WriteLine("3. Choose All Question");
                            Console.WriteLine("Chooce between number (1 - 2 - 3)");

                            int chioce = Convert.ToInt32(Console.ReadLine());
                            switch (chioce)
                            {
                                case 1:
                                    Console.Write("Enter the Question Body ");
                                    string body = Console.ReadLine();
                                    Console.Write("Enter the Question Mark ");
                                    int mark = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter the Question Level ");
                                    string header = Console.ReadLine();

                                    Question question1 = new TrueFalseQuestion();

                                    Answer answer = new Answer();
                                    answer.CrrectAnswer();
                                    AnswerList answerList = new AnswerList(input);
                                    answerList.AddAnswer(answer);

                                    break;
                                case 2:
                                    Console.Write("Enter the Question Body ");
                                    body = Console.ReadLine();
                                    Console.Write("Enter the Question Mark ");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter the Question Level ");
                                    header = Console.ReadLine();

                                    Console.Write("Enter First Answer : ");
                                    string firstAnswer = Console.ReadLine();
                                    Console.Write("Enter Second Answer : ");
                                    string secondAnswer = Console.ReadLine();
                                    Console.Write("Enter Third Answer : ");
                                    string thirdAnswer = Console.ReadLine();
                                    Console.Write("Enter Fourth Answer : ");
                                    string fourthAnswer = Console.ReadLine();

                                    Answer answer1 = new Answer();
                                    answer1.CrrectAnswer();
                                    AnswerList answerList1 = new AnswerList(input);
                                    answerList1.AddAnswer(answer1);
                                    break;
                                case 3:
                                    Console.Write("Enter the Question Level ");
                                    header = Console.ReadLine();
                                    Console.Write("Enter the Question Body ");
                                    body = Console.ReadLine();
                                    Console.Write("Enter the Question Mark ");
                                    mark = Convert.ToInt32(Console.ReadLine());


                                    Console.Write("Enter First Answer : ");
                                    firstAnswer = Console.ReadLine();
                                    Console.Write("Enter Second Answer : ");
                                    secondAnswer = Console.ReadLine();
                                    Console.Write("Enter Third Answer : ");
                                    thirdAnswer = Console.ReadLine();
                                    Console.Write("Enter Fourth Answer : ");
                                    fourthAnswer = Console.ReadLine();

                                    Question question3 = new ChooseAllQuestion();

                                    Answer answer2 = new Answer();
                                    answer2.CrrectAnswer();
                                    answer2.CrrectAnswer();
                                    AnswerList answerList2 = new AnswerList(input);
                                    answerList2.AddAnswer(answer2);
                                    break;
                            }
                        }
                        break;

                    case 2:
                        QuestionList questionList1 = new QuestionList(input);
                        Console.WriteLine("\n--- Student Mode: Displaying Questions ---\n");
                        questionList1.DisplayAllQuestions();
                        break;

                }
            }
        }
    }
}
