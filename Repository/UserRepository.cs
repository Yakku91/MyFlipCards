using MyCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCards.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly MycardsContext mycardsContext;

        public UserRepository()
        {
            mycardsContext = new MycardsContext();        
        }
        public void Add(User entity)
        {
            if (entity is not null)
            {
                var user = findUserByEmailAndUsername(entity);
                if (user != null) 
                {
                    throw new Exception("User bereits existiert!");
                }
                mycardsContext.Users.Add(entity);
                mycardsContext.SaveChanges();
                Category category = new Category();
                category.Name = "Alle";
                category.UserId = entity.Id;
                mycardsContext.Categories.Add(category);
                mycardsContext.SaveChanges();
            }
        }

        public void delete(User entity)
        {
            if (entity is not null)
            {
                List<Category> categories = mycardsContext.Categories.Where(c => c.UserId == entity.Id).ToList();
                foreach (var category in categories) 
                {
                    List<Card> cards = mycardsContext.Cards.Where(e => e.CategoryId == category.Id).ToList();
                    mycardsContext.RemoveRange(cards);
                }
                mycardsContext.Categories.RemoveRange(categories);
                mycardsContext.Users.Remove(entity);
                mycardsContext.SaveChanges();
            }
        }

        public User? FindById(int id)
        {
             return mycardsContext.Users.Find(id);
        }

        public List<User> GetAll()
        {
            return mycardsContext.Users.ToList();
        }

        public void update(User entity)
        {
            if (entity is not null)
            {
                User existUser = checkEmail(entity);
                if (existUser != null)
                {
                    throw new Exception("Diese Emailadresse wird von einem anderen Benutzer verwendet.");
                }
                else if (checkUsername(entity) != null)
                {
                    throw new Exception("Dieser Benutzername wird von einem anderen Benutzer verwendet.");
                }

                mycardsContext.Users.Update(entity);
                mycardsContext.SaveChanges();
            }
        }
        public User? findByUserName(string username, string passwort)
        {
            var user = mycardsContext.Users.FirstOrDefault(e => e.Username.Equals(username) && e.Password.Equals(passwort));
            return user;
        }
        public User? findUserByEmailAndUsername(User entity)
        {
            return mycardsContext.Users.FirstOrDefault(e => e.Email.Equals(entity.Email) || e.Username.Equals(entity.Username));
        }
        private User? checkUsername(User user)
        {
            return mycardsContext.Users.FirstOrDefault(e => e.Id != user.Id && e.Username.Equals(user.Username));
        }
        private User? checkEmail(User user)
        {
            return mycardsContext.Users.FirstOrDefault(e => e.Id != user.Id && e.Email.Equals(user.Email));
        }
    }
}
