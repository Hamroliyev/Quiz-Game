Console.WriteLine("\t... Welcome Quiz Game ... ");
int quizNumber = 1;
int correctAnswers = 0;
Random random = new Random();
char[] alphabet = Enumerable.Range('A', 26).Select(asciiCode => (char)asciiCode).ToArray();

do
{

    quizNumber++;
} while (quizNumber < 4);