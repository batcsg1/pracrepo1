namespace AverageGradeCalculator
{
    internal class Program
    {
        static void Main()
        {
            // Declare and initialize sentence variable
            string sentence = " Converted from Uppercase ";

            //DISPLAY SENTENCE
            Console.WriteLine(sentence);

            // Create new strings to add into the new sentence
            string firstNewString = "Transformed &";
            string secondNewString = "Yay!!!";

            // Insert new strings into newsentence
            string newsentence = sentence.Insert(0, firstNewString);
            newsentence = sentence.Insert(25, " " + secondNewString);

            // Replace words in the new sentence
            newsentence = newsentence.Replace("Uppercase", "UPPER");

            //Trim spaces in new sentence
            newsentence = newsentence.Trim();


            // DISPLAY NEW SENTENCE
            Console.WriteLine(newsentence);

            
            // Split newsentence into an array of words
            string[] splitsentence = newsentence.Split(' ');

            //DECLARE FINAL SENTENCE
            string finalsentence = "";
            
            foreach (string word in splitsentence)
            {
                // Modify each word to have lowercase first character
                string modifiedWord = (word[0].ToString().ToLower() + word.Substring(1));
                finalsentence += modifiedWord + " ";
            }

            // Print the final sentence with lowercase first characters
            Console.WriteLine(finalsentence);

            //Create array for finalsentence

            string[] splitfinalsentence = finalsentence.Split(" ");

            foreach (string words in splitfinalsentence)
            {

                Console.WriteLine(words);

            }

            Console.ReadLine();







        }
    }
}
