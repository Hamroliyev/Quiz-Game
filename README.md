# Quiz-Game

This development is about the English alphabet and it can help you improve some 
language skills. Try it out and enhance your knowledge. 
It's time to get better.
Let's have a look at the code parts.

## Fields

`
    int quizNumber = 1;
    int correctAnswers = 0;
    int randomNumber;
    string answer;
    char[] alphabet = Alphabet();
    string isContinued;
`

## Main Part

`
    do
    {
        CheckAnswers();
        PrintResult(quizNumber-1);
        Console.Write("Do you want to continue Yes/No : ");
        isContinued = Console.ReadLine();
    } while (isContinued == "Yes");
`

## Mehtods

`
    **WelcomeApp Method =>**
        void WelcomeApp()
        {
            Console.Clear();
            Console.WriteLine("\t... Welcome Quiz Game ... \n");
        }
    **RandomNumber Method =>**
    int RandomNumber()
    {
        Random random = new Random();
        return random.Next(1,26);
    }
    **Alphabet Method =>**
    char[] Alphabet()
    {
        return Enumerable.Range('A', 26).Select(asciiCode => (char)asciiCode).ToArray();
    }
    **CheckAnswer Method =>**
    void CheckAnswer(string answer)
    {
        if (answer.Length != 1)
        {
            Console.WriteLine("Wrong input try it again");
            return;
        }
    
        if (answer == alphabet[randomNumber-1].ToString())
        {
            Console.WriteLine($"{quizNumber}-question is answerd correctly.");
            correctAnswers ++;
        }
        else
        {
            Console.WriteLine($"{quizNumber}-question isn't answerd correctly.");
        }
    }
    **CheckAnswers Method =>**
    void CheckAnswers()
    {
        do
        {
            randomNumber = RandomNumber();
            Console.Write($"Which letter lands in {randomNumber} position in the English alphabet : ");
            answer = Console.ReadLine();
    
            CheckAnswer(answer);
    
            quizNumber++;
        } while (quizNumber < 4);
    }
    
    void PrintResult(int total)
    {
        Console.WriteLine($"\n\t... You find {correctAnswers} questions out of {total}. ...\n");
    }
`
