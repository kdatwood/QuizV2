using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Preston Stinnett";
            string course = "ENGR 115";
            string assignmentTitle = "Checkpoint 3";


            string question1 = "Q1: Which new fighter jet is used by the Marines, Air Force, and Navy?";
            string q1answer1 = "A. F-35";
            string q1answer2 = "B. F-4";
            string q1answer3 = "C. B-17";
            string q1answer4 = "D. C-130";
            string answerGiven1;

            string question2 = "Q2: The AH-64 Apache/Longbow is the only helicopter in service for the United States Army.";
            string q2answer1 = "A. True";
            string q2answer2 = "B. False";
            string answerGiven2;

            string question3 = "Q3: Which aircraft was used during the Cold War and had to have astronaut training for it?";
            string q3answer1 = "A. F-16";
            string q3answer2 = "B. UH-60";
            string q3answer3 = "C. F-15";
            string q3answer4 = "D. SR-71";
            string answerGiven3;

            string question4 = "Q4: The Apache helicopter is the successor of the Cobra helicopter.";
            string q4answer1 = "A. True";
            string q4answer2 = "B. False";
            string answerGiven4;

            string question5 = "Q5: Which airplane is built around its iconic 30 mm machine gun?";
            string q5answer1 = "A. F-18";
            string q5answer2 = "B. A-10";
            string q5answer3 = "C. B-52";
            string q5answer4 = "D. F-117";
            string answerGiven5;

            string question6 = "Q6: Lockheed-Martin manufactured and produced the F-117 Nighthawk.";
            string q6answer1 = "A. True";
            string q6answer2 = "B. False";
            string answerGiven6;

            string question7 = "Q7: Which company produced the KC-135 Stratotanker?";
            string q7answer1 = "A. Lockheed-Martin";
            string q7answer2 = "B. Northrop Grumman";
            string q7answer3 = "C. Boeing";
            string q7answer4 = "D. General Dynamics Corporation";
            string answerGiven7;

            string question8 = "Q8: Lockeed-Martin produced the F-16.";
            string q8answer1 = "A. True";
            string q8answer2 = "B. False";
            string answerGiven8;

            string question9 = "Q9: Which branch of the United States Military used the AV-8B Harrier II?";
            string q9answer1 = "A. Army";
            string q9answer2 = "B. Navy";
            string q9answer3 = "C. Marine Corps";
            string q9answer4 = "D. Air Force";
            string answerGiven9;

            string question10 = "Q10: The SR-71 is still in commission and flying today.";
            string q10answer1 = "A. True";
            string q10answer2 = "B. False";
            string answerGiven10;

            bool answer1Correct = false;
            bool answer2Correct = false;
            bool answer3Correct = false;
            bool answer4Correct = false;
            bool answer5Correct = false;
            bool answer6Correct = false;
            bool answer7Correct = false;
            bool answer8Correct = false;
            bool answer9Correct = false;
            bool answer10Correct = false;


            Console.WriteLine(myName);
            Console.WriteLine(course);
            Console.WriteLine(assignmentTitle);
            Console.WriteLine();


            int roundsDone = 0;
            do
            {
                if(roundsDone == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("You get one more chance on the questions you answered wrong!");
                    Console.WriteLine();
                }

                if(answer1Correct == false)
                {
                    Console.WriteLine(question1);
                    Console.WriteLine();
                    Console.WriteLine(q1answer1);
                    Console.WriteLine(q1answer2);
                    Console.WriteLine(q1answer3);
                    Console.WriteLine(q1answer4);
                    Console.WriteLine();

                    answerGiven1 = Console.ReadLine();
                    Console.WriteLine();

                    if (answerGiven1.Length != 1)
                    {
                        Console.WriteLine("You entered an incorrect format as an answer. It will be marked as wrong.");
                        Console.WriteLine();

                        break;
                    }

                    if(answerGiven1 == "a" || answerGiven1 == "A")
                    {
                        Console.WriteLine("You answered correct.");
                        answer1Correct = true;
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.");
                    }

                    Console.WriteLine("The answer you chose was " + answerGiven1);
                    Console.WriteLine();
                }

                if (answer2Correct == false)
                {
                    Console.WriteLine(question2);
                    Console.WriteLine();
                    Console.WriteLine(q2answer1);
                    Console.WriteLine(q2answer2);
                    Console.WriteLine();

                    answerGiven2 = Console.ReadLine();
                    Console.WriteLine();

                    if (answerGiven2.Length != 1)
                    {
                        Console.WriteLine("You entered an incorrect format as an answer. It will be marked as wrong.");
                        Console.WriteLine();

                        break;
                    }

                    if (answerGiven2 == "b" || answerGiven2 == "B")
                    {
                        Console.WriteLine("You answered correct.");
                        answer2Correct = true;
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.");
                    }

                    Console.WriteLine("The answer you chose was " + answerGiven2);
                    Console.WriteLine();
                }



                if (answer3Correct == false)
                {
                    Console.WriteLine(question3);
                    Console.WriteLine();
                    Console.WriteLine(q3answer1);
                    Console.WriteLine(q3answer2);
                    Console.WriteLine(q3answer3);
                    Console.WriteLine(q3answer4);
                    Console.WriteLine();

                    answerGiven3 = Console.ReadLine();
                    Console.WriteLine();

                    if (answerGiven3.Length != 1)
                    {
                        Console.WriteLine("You entered an incorrect format as an answer. It will be marked as wrong.");
                        Console.WriteLine();

                        break;
                    }

                    if (answerGiven3 == "d" || answerGiven3 == "D")
                    {
                        Console.WriteLine("You answered correct.");
                        answer3Correct = true;
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.");
                    }

                    Console.WriteLine("The answer you chose was " + answerGiven3);
                    Console.WriteLine();
                }


                if (answer4Correct == false)
                {

                    Console.WriteLine(question4);
                    Console.WriteLine();
                    Console.WriteLine(q4answer1);
                    Console.WriteLine(q4answer2);
                    Console.WriteLine();

                    answerGiven4 = Console.ReadLine();
                    Console.WriteLine();

                    if (answerGiven4.Length != 1)
                    {
                        Console.WriteLine("You entered an incorrect format as an answer. It will be marked as wrong.");
                        Console.WriteLine();

                        break;
                    }

                    if (answerGiven4 == "a" || answerGiven4 == "A")
                    {
                        Console.WriteLine("You answered correct.");
                        answer4Correct = true;
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.");
                    }

                    Console.WriteLine("The answer you chose was " + answerGiven4);
                    Console.WriteLine();
                }


                if (answer5Correct == false)
                {

                    Console.WriteLine(question5);
                    Console.WriteLine();
                    Console.WriteLine(q5answer1);
                    Console.WriteLine(q5answer2);
                    Console.WriteLine(q5answer3);
                    Console.WriteLine(q5answer4);
                    Console.WriteLine();

                    answerGiven5 = Console.ReadLine();
                    Console.WriteLine();

                    if (answerGiven5.Length != 1)
                    {
                        Console.WriteLine("You entered an incorrect format as an answer. It will be marked as wrong.");
                        Console.WriteLine();

                        break;
                    }

                    if (answerGiven5 == "b" || answerGiven5 == "B")
                    {
                        Console.WriteLine("You answered correct.");
                        answer5Correct = true;
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.");
                    }

                    Console.WriteLine("The answer you chose was " + answerGiven5);
                    Console.WriteLine();
                }



                if (answer6Correct == false)
                {

                    Console.WriteLine(question6);
                    Console.WriteLine();
                    Console.WriteLine(q6answer1);
                    Console.WriteLine(q6answer2);
                    Console.WriteLine();

                    answerGiven6 = Console.ReadLine();
                    Console.WriteLine();

                    if (answerGiven6.Length != 1)
                    {
                        Console.WriteLine("You entered an incorrect format as an answer. It will be marked as wrong.");
                        Console.WriteLine();

                        break;
                    }

                    if (answerGiven6 == "a" || answerGiven6 == "A")
                    {
                        Console.WriteLine("You answered correct.");
                        answer6Correct = true;
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.");
                    }

                    Console.WriteLine("The answer you chose was " + answerGiven6);
                    Console.WriteLine();
                }



                if (answer7Correct == false)
                {

                    Console.WriteLine(question7);
                    Console.WriteLine();
                    Console.WriteLine(q7answer1);
                    Console.WriteLine(q7answer2);
                    Console.WriteLine(q7answer3);
                    Console.WriteLine(q7answer4);
                    Console.WriteLine();

                    answerGiven7 = Console.ReadLine();
                    Console.WriteLine();

                    if (answerGiven7.Length != 1)
                    {
                        Console.WriteLine("You entered an incorrect format as an answer. It will be marked as wrong.");
                        Console.WriteLine();

                        break;
                    }

                    if (answerGiven7 == "c" || answerGiven7 == "C")
                    {
                        Console.WriteLine("You answered correct.");
                        answer7Correct = true;
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.");
                    }

                    Console.WriteLine("The answer you chose was " + answerGiven7);
                    Console.WriteLine();
                }



                if (answer8Correct == false)
                {

                    Console.WriteLine(question8);
                    Console.WriteLine();
                    Console.WriteLine(q8answer1);
                    Console.WriteLine(q8answer2);
                    Console.WriteLine();

                    answerGiven8 = Console.ReadLine();
                    Console.WriteLine();

                    if (answerGiven8.Length != 1)
                    {
                        Console.WriteLine("You entered an incorrect format as an answer. It will be marked as wrong.");
                        Console.WriteLine();

                        break;
                    }

                    if (answerGiven8 == "b" || answerGiven8 == "B")
                    {
                        Console.WriteLine("You answered correct.");
                        answer8Correct = true;
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.");
                    }

                    Console.WriteLine("The answer you chose was " + answerGiven8);
                    Console.WriteLine();
                }



                if (answer9Correct == false)
                {

                    Console.WriteLine(question9);
                    Console.WriteLine();
                    Console.WriteLine(q9answer1);
                    Console.WriteLine(q9answer2);
                    Console.WriteLine(q9answer3);
                    Console.WriteLine(q9answer4);
                    Console.WriteLine();

                    answerGiven9 = Console.ReadLine();
                    Console.WriteLine();

                    if (answerGiven9.Length != 1)
                    {
                        Console.WriteLine("You entered an incorrect format as an answer. It will be marked as wrong.");
                        Console.WriteLine();

                        break;
                    }

                    if (answerGiven9 == "c" || answerGiven9 == "C")
                    {
                        Console.WriteLine("You answered correct.");
                        answer9Correct = true;
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.");
                    }

                    Console.WriteLine("The answer you chose was " + answerGiven9);
                    Console.WriteLine();
                }


                if (answer10Correct == false)
                {
                    Console.WriteLine(question10);
                    Console.WriteLine();
                    Console.WriteLine(q10answer1);
                    Console.WriteLine(q10answer2);
                    Console.WriteLine();

                    answerGiven10 = Console.ReadLine();
                    Console.WriteLine();

                    if (answerGiven10.Length != 1)
                    {
                        Console.WriteLine("You entered an incorrect format as an answer. It will be marked as wrong.");
                        Console.WriteLine();

                        break;
                    }

                    if (answerGiven10 == "b" || answerGiven10 == "B")
                    {
                        Console.WriteLine("You answered correct.");
                        answer10Correct = true;
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.");
                    }

                    Console.WriteLine("The answer you chose was " + answerGiven10);
                    Console.WriteLine();
                }

                roundsDone++;
            } while (roundsDone < 2);

            int correctAnswers = 0;

            if(answer1Correct == true)
            {
                correctAnswers++;
            }

            if (answer2Correct == true)
            {
                correctAnswers++;
            }

            if (answer3Correct == true)
            {
                correctAnswers++;
            }

            if (answer4Correct == true)
            {
                correctAnswers++;
            }

            if (answer5Correct == true)
            {
                correctAnswers++;
            }

            if (answer6Correct == true)
            {
                correctAnswers++;
            }

            if (answer7Correct == true)
            {
                correctAnswers++;
            }

            if (answer8Correct == true)
            {
                correctAnswers++;
            }

            if (answer9Correct == true)
            {
                correctAnswers++;
            }

            if (answer10Correct == true)
            {
                correctAnswers++;
            }

            int wrongAnswers = 10 - correctAnswers;

            Console.WriteLine("You got " + correctAnswers + " correct and " + wrongAnswers + " incorrect.");
            Console.ReadKey();



















        }
    }
}
