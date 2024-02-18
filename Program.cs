WelcomeApp();

int quizNumber = 1;
int correctAnswers = 0;
int randomNumber;
string answer;
char[] alphabet = Alphabet();
string isContinued;

do
{
    CheckAnswers();
    PrintResult();
    Console.Write("Do you want to continue Yes/No : ");
    isContinued = Console.ReadLine();
} while (isContinued == "Yes");

void WelcomeApp()
{
    Console.Clear();
    Console.WriteLine("\t... Welcome Quiz Game ... \n");
}

int RandomNumber()
{
    Random random = new Random();
    return random.Next(1,26);
}

char[] Alphabet()
{
    return Enumerable.Range('A', 26).Select(asciiCode => (char)asciiCode).ToArray();
}

void CheckAnswer(string answer)
{
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

void PrintResult()
{
    Console.WriteLine($"\n\t... You find {correctAnswers} questions out of 3. ...\n");
}