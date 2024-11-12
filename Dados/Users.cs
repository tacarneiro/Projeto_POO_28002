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
using System.Data;
using System.Xml.Linq;

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

        public static List<User> GetUsers()
        {
            return users;
        }
        #endregion

        #region OUTROS MÉTODOS
        /// <summary>
        /// Load User Function
        /// </summary>
        /// 
        public static bool LoadUsers(out List<User> users)
        {
            string filePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Bd\\Users.txt";
            users = new List<User>();

            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFound();
                

                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var parts = line.Split(',');

                    if (parts.Length != 6)
                        throw new InvalidLineFormatException();
                    

                    Guid id;
                    if (!Guid.TryParse(parts[0], out id))
                        throw new InvalidGuidException("Formato de ID inválido.");
                    

                    string name = parts[1],
                           email = parts[2];

                    DateTime dataNascimento;
                    if (!DateTime.TryParseExact(parts[3], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
                        throw new InvalidDateFormatException();
                    

                    string password = parts[4],
                           role = parts[5];

                    var user = new User(id, name, email, dataNascimento, password, role);
                    users.Add(user);
                }

                return true;
            }
            catch (FileNotFound ex)
            {
                throw new Exception(ex.Message);
            }
            catch (InvalidLineFormatException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (InvalidDateFormatException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (InvalidGuidException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (NullArgumentException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Add User Function
        /// </summary>
        /// 
        public static bool AddUser(User user)
        {
            string filePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Bd\\Users.txt";

            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFound();

                if (!ValidateUserExists(user.Email))
                {
                    string userData = $"{user.Id},{user.Name},{user.Email},{user.DataNascimento},{user.Password},{user.Role}";
                    File.AppendAllText(filePath, userData + Environment.NewLine);
                    users.Add(user);

                    return true;
                }
                else
                {
                    throw new UserExistsException("Já existe um user com este email.");
                }
            }
            catch(UserExistsException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (FileNotFound ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Validate User Exists Function
        /// </summary>
        /// 
        public static bool ValidateUserExists(string email)
        {
            if (users.Count > 0)
            {
                foreach (User user in users)
                {
                    if (user.Email == email)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion
    }
}
