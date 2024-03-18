using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MySql.Data
{
    public class UserRepository
    {
        private readonly MySqlDatabase _database;

        public UserRepository(MySqlDatabase database)
        {
            _database = database;
        }

        public List<User> GetAll()
        {
            _database.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users", _database.Connection);
            MySqlDataReader reader = command.ExecuteReader();

            List<User> users = new List<User>();

            while (reader.Read())
            {
                User user = new User
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Email = reader.GetString("email")
                };

                users.Add(user);
            }

            reader.Close();
            _database.Close();

            return users;
        }

        public User? GetById(int id)
        {
            _database.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE id = @id", _database.Connection);
            command.Parameters.AddWithValue("@id", id);

            MySqlDataReader reader = command.ExecuteReader();

            User? user = null;

            if (reader.Read())
            {
                user = new User
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Email = reader.GetString("email")
                };
            }

            reader.Close();
            _database.Close();

            return user;
        }

        public void Add(User user)
        {
            _database.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO users (name, email) VALUES (@name, @email)", _database.Connection);
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@email", user.Email);

            command.ExecuteNonQuery();

            _database.Close();
        }

        public void Update(User user)
        {
            _database.Open();

            MySqlCommand command = new MySqlCommand("UPDATE users SET name = @name, email = @email WHERE id = @id", _database.Connection);
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@id", user.Id);

            command.ExecuteNonQuery();

            _database.Close();
        }

        public void Delete(int id)
        {
            _database.Open();

            MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE id = @id", _database.Connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            _database.Close();
        }
    }
}