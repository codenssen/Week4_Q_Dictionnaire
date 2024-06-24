namespace Week4_Q_Dictionnaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Je veux que tu commences ton dictionnaire avec trois lettres: 'a', 'b' et 'c'.
            // Je veux que tu associes trois mots à ces trois lettres.
            Dictionary<char, string> dictionnaire = new Dictionary<char, string>();
            dictionnaire.Add('a', "bonjour");
            dictionnaire.Add('b', "à");
            dictionnaire.Add('c', "tous");

            // Affichage des mots du dictionnaire
            foreach(string word in dictionnaire.Values)
            {
                Console.WriteLine(word);
            }

            // J'ai aussi besoin que tu me prouves que tu sais faire le ménage.
            // Supprime-moi la lettre 'c' après l'avoir créée.
            dictionnaire.Remove('c');

            // Affichage des mots du dictionnaire
            foreach (string word in dictionnaire.Values)
            {
                Console.WriteLine(word);
            }
        }
    }
}
