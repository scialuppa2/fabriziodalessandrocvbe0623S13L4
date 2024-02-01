namespace esercizioS13L4
{
    internal class Program
    {
       
      
        static void Main(string[] args)
        {
                Utente.Menu();
        }
        

        public static class Utente
        {
            public static string Username = "myUsername";
            public static string Password = "myPassword";

            public static bool Verify = false;
            public static DateTime DataOra;
            public static List<DateTime> Accessi = new List<DateTime>();


            public static void Menu()
            {
                int scelta;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("=========================================");
                    Console.WriteLine("              O P E R A Z I O N I        ");
                    Console.WriteLine("=========================================");
                    Console.WriteLine();
                    Console.WriteLine("1.: Login");
                    Console.WriteLine("2.: Logout");
                    Console.WriteLine("3.: Verifica ora e data di login");
                    Console.WriteLine("4.: Lista degli accessi");
                    Console.WriteLine("5.: Esci");
                    Console.WriteLine();
                    Console.Write("Seleziona un'opzione: ");

                    if (int.TryParse(Console.ReadLine(), out scelta))
                    {
                        switch (scelta)
                        {
                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("Hai selezionato opzione 1: Login");
                                Login();
                                break;
                            case 2:
                                Console.WriteLine();
                                Console.WriteLine("Hai selezionato opzione 2: Logout");
                                Logout();
                                break;
                            case 3:
                                Console.WriteLine();
                                Console.WriteLine("Hai selezionato opzione 3: Verifica ora e data di login");
                                VerificaOraData();
                                break;
                            case 4:
                                Console.WriteLine();
                                Console.WriteLine("Hai selezionato opzione 4: Lista degli accessi");
                                ListaAccessi();
                                break;
                            case 5:
                                Console.WriteLine();
                                Console.WriteLine("Hai selezionato opzione 5: Exit");
                                Exit();
                                break;
                            default:
                                Console.WriteLine("Scelta non valida. Riprova.");
                                break;
                        }
                    }
                    
                }
                while (scelta != 5);
            }

            public static void Login()
            {
                Console.WriteLine("Inserisci lo username (myUsername):");
                string inputUsername = Console.ReadLine();
                Console.WriteLine("Inserisci la password (myPassword):");
                string inputPassword = Console.ReadLine();
                Console.Write("Conferma la password: ");
                string confermaPassword = Console.ReadLine();

                if (inputUsername == Username && inputPassword == Password && Password == confermaPassword)
                {
                    Verify = true;
                    DataOra = DateTime.Now;
                    Accessi.Add(DataOra);
                    Console.WriteLine("Login effettuato con successo");
                }
                else
                {
                    Console.WriteLine("Errore, credenziali errate");
                }
            }

            public static void Logout()
            {
                if (Verify == true)
                {
                    Console.WriteLine("Logout effettuato con successo");
                }
                else
                {
                    Console.WriteLine("Errore, utente non loggato");
                }
            }

            public static void VerificaOraData()
            {
                if (Verify == true)
                {
                    Console.WriteLine($"Ora e data di login: {DataOra}");
                }
                else
                {
                    Console.WriteLine("Errore, utente non loggato");
                }
            }

            public static void ListaAccessi()
            {
                if (Accessi.Count > 0)
                {
                    foreach (var accesso in Accessi)
                    {
                        Console.WriteLine(accesso);
                    }
                }
                else
                {
                    Console.WriteLine("Nessun accesso registrato.");
                }
            }

            public static void Exit()
            {
                Environment.Exit(0);
            }
        }
    }
}
