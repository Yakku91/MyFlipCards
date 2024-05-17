using Microsoft.EntityFrameworkCore;
using MyCards.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCards.Repository
{
    internal class CardRepository : IRepository<Card>
    {
        private readonly MycardsContext context;
        public CardRepository() 
        { 
            context = new MycardsContext();
        }
        public void Add(Card entity)
        {
            context.Cards.Add(entity);
            context.SaveChanges();
        }

        public void delete(Card entity)
        {
            context.Cards.Remove(entity);
            context.SaveChanges();
        }

        public Card FindById(int id)
        {
            return context.Cards.First(x => x.Id == id);
        }

        public List<Card> GetAll()
        {
            List<int> categoryIdList;
            categoryIdList = context.Categories.Where(e => e.UserId == App.currentUser.Id).Select(e=> e.Id).ToList();
            return context.Cards.Where(e => categoryIdList.Contains(e.CategoryId)).ToList();
        }
        public List<Card> getByCategoryId(int categoryId)
        {
            return context.Cards.Where(e => e.CategoryId == categoryId).ToList();
        }
        public void update(Card entity)
        {
            context.Cards.Update(entity);
            context.SaveChanges(true);
        }
    }
}
