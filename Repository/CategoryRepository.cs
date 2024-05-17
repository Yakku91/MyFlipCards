using Microsoft.EntityFrameworkCore;
using MyCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyCards.Repository
{
    internal class CategoryRepository : IRepository<Category>
    {
        private readonly MycardsContext mycardsContext;
        public CategoryRepository() 
        {
            mycardsContext = new MycardsContext();
        }
        public void Add(Category entity)
        {
            if(entity is not null)
            {
                var existCategory = mycardsContext.Categories.FirstOrDefault(e => e.Name.Equals(entity.Name) && e.UserId == entity.UserId);
                if (existCategory != null)
                { 
                    throw new InvalidOperationException("Diese Kategorie existiert!");
                }
                mycardsContext.Categories.Add(entity);
                mycardsContext.SaveChanges();
               
            }
            else
            {
                throw new Exception("User ist null");
            }
           
        }

        public void delete(Category entity)
        {
            List<Card> cards = mycardsContext.Cards.Where(c => c.CategoryId == entity.Id).ToList();
            if (cards is not null)
            {
                mycardsContext.Cards.RemoveRange(cards);
            }
            mycardsContext?.Categories.Remove(entity);
            mycardsContext?.SaveChanges();
        }

        public Category FindById(int id)
        {
            return mycardsContext.Categories.Single(e=> e.Id == id);
        }

        public List<Category> GetAll()
        {
            return mycardsContext.Categories.Where(e=> e.UserId == App.currentUser.Id).ToList();
        }
        public List<Category> GetAllWithoutAlle()
        {
            return mycardsContext.Categories.Where(e => e.UserId == App.currentUser.Id && !e.Name.Equals("Alle")).OrderByDescending(e=> e.Id).ToList();
        }

        public void update(Category entity)
        {
            mycardsContext.Categories.Update(entity);
            mycardsContext.SaveChanges();
        }
    }
}