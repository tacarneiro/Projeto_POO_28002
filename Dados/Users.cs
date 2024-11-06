using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Excecoes;
using Objects;
using static Excecoes.Excecoes;
using System.Configuration;

namespace Dados
{
    public class Users
    {
        /// <summary>
        /// Users Class
        /// </summary>
        /// 
        #region ATRIBUTOS
        private static List<User> users = new List<User>();
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OUTROS MÉTODOS
        /// <summary>
        /// Load User Function
        /// </summary>
        /// 
        public static List<User>? LoadUsers(out string errorMessage)
        {
            string filePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Bd\\Users.txt";
            var users = new List<User>();
            errorMessage = null;

            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFound();
                }

                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var parts = line.Split(',');

                    if (parts.Length != 6)
                    {
                        throw new InvalidLineFormatException();
                    }

                    Guid id;
                    if (!Guid.TryParse(parts[0], out id))
                    {
                        throw new InvalidGuidException("Formato de ID inválido.");
                    }

                    string name = parts[1],
                           email = parts[2];

                    DateTime dataNascimento;
                    if (!DateTime.TryParseExact(parts[3], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
                    {
                        throw new InvalidDateFormatException();
                    }

                    string password = parts[4],
                           role = parts[5];

                    var user = new User(id, name, email, dataNascimento, password, role);
                    users.Add(user);
                }

                return users;
            }
            catch (FileNotFound ex)
            {
                errorMessage = ex.Message;
                return null;
            }
            catch (InvalidLineFormatException ex)
            {
                errorMessage = ex.Message;
                return null;
            }
            catch (InvalidDateFormatException ex)
            {
                errorMessage = ex.Message;
                return null;
            }
            catch (InvalidGuidException ex)
            {
                errorMessage = ex.Message;
                return null;
            }
            catch (NullArgumentException ex)
            {
                errorMessage = ex.Message;
                return null;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return null;
            }
        }
        #endregion
    }
}
