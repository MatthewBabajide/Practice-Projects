// See https://aka.ms/new-console-template for more information
char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

Console.WriteLine("Please enter Secret message");
string message = Console.ReadLine().ToLower();
char[] secretMessage = message.ToCharArray();
char[] encryptedMessage = new char[secretMessage.Length];
for (int i = 0; i < secretMessage.Length; i++)
{
    char messageChar = secretMessage[i];
    int charIndex = Array.IndexOf(alphabet, messageChar);
    int newCharIndex = (charIndex + 3) % alphabet.Length;
    char newChar = alphabet[newCharIndex];
    encryptedMessage[i] = newChar;
}
string encriptedMsg = String.Join("", encryptedMessage);
Console.WriteLine(encriptedMsg);