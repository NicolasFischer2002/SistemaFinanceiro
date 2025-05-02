namespace SistemaFinanceiro
{
    internal static class Program
    {
        // Definição publica do caminho do arquivo JSON
        public static readonly string CaminhoArquivoJSON = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BancoDados.json");

        /// <summary>
        ///  The main entry point for the app lication.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormInicial());

            // Verificação ou Criação do banco de dados JSON
            try
            {
                // Metodo tradicional de definição de caminho
                // string CaminhoExe = AppDomain.CurrentDomain.BaseDirectory;
                // string CaminhoArquivoJSON = Path.Combine(CaminhoExe, "BancoDados.json"); 

                if (!File.Exists(CaminhoArquivoJSON))
                {
                    Console.WriteLine("JSON inexistente, criando novo...");                    
                    File.Create(CaminhoArquivoJSON).Close();                    
                }
                else
                {
                    Console.WriteLine("JSON encontrado");
                }                               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar criar ou encontrar o JSON: {ex.Message}");
            }

        }
    }
}
