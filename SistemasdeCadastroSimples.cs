using System;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
         string conexao =
            @"Data Source=C:\Users\andrei\Documents\treino\treino117\SistemadeCadastroSimples\lgl.db";

        using (var connection = new SqliteConnection(conexao))
        {
            connection.Open();
        Console.WriteLine("=== Sistema de Cadastro de Email ===");
        Console.WriteLine("Aperte 1 para cadastrar e 2 para entrar em uma conta existente");
        if (int.TryParse(Console.ReadLine(), out int Opção))
        {
            if (Opção == 1)
            {
            
            


                 Console.Write("Digite seu email: ");
        string? email = Console.ReadLine();
        Console.WriteLine("Digite sua senha");
        string? sinha = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
{
    Console.WriteLine("Email inválido.");
    return;
}

        else if (string.IsNullOrWhiteSpace(sinha))
        {
            Console.WriteLine("senha inválida.");
            return;
        }

       

            try
            {
                using (var comando = connection.CreateCommand())
                {
                    comando.CommandText =
                        @"INSERT INTO Emails (Email, Senha) VALUES (@email, @sinha);";

                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@sinha", sinha);
                    comando.ExecuteNonQuery();
                }

            



                Console.WriteLine("Email cadastrado com sucesso!");
            }
        
           
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado:");
                Console.WriteLine(ex.Message);
            }

            

        }
        else
                {
                    Console.Write("Digite seu Email para entrar: ");
                    string? entrarEmail = Console.ReadLine();
                    Console.Write("Digite sua senha: ");
                    string? entrarSenha = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(entrarEmail) || string.IsNullOrWhiteSpace(entrarSenha))
                    {
                        Console.WriteLine("Email ou senha inválidos.");
                    }
                    else
                    {
                        try
                        {
                            using (var comando = connection.CreateCommand())
                            {
                                comando.CommandText =
                                    @"SELECT Senha, Email FROM Emails WHERE Email = @Entrar;";

                                comando.Parameters.AddWithValue("@Entrar", entrarEmail);

                                using (var reader = comando.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        var senhaNoBanco = reader.GetString(0);
                                        if (senhaNoBanco == entrarSenha)
                                        {
                                            Console.WriteLine("Login efetuado com sucesso!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Senha incorreta.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Email não encontrado.");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erro inesperado:");
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
        }
    }
}
                
                



            


         
    }
                
                
            

    
   
        
        

