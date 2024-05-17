using MyCards.MessageBoxes;
using MyCards.Models;
using MyCards.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace MyCards.ViewModels
{
    public class CardViewModel : BaseViewModel
    {
        private CardRepository cardRepository;
        private CategoryRepository categoryRepository;
        private Category selectedCategory;
        private List<Card> cards;
        public List<Card> Cards { get { return cards; } set { cards = value; OnPropertyChanged(nameof(Cards)); } }
        private List<Category> categories;
        public List<Category> Categories { get { return categories; } set { categories = value; OnPropertyChanged(nameof(categories)); } }

        public CardViewModel()
        {
            cardRepository = new CardRepository();
            categoryRepository = new CategoryRepository();
            GetAll();
        }

        public void GetAll()
        {
            categories = categoryRepository.GetAll();

            if (selectedCategory == null || selectedCategory.Name.Equals("Alle"))
            {
                Cards = cardRepository.GetAll();
            }
            else
            {
                Cards = cardRepository.getByCategoryId(selectedCategory.Id);                
            }            
        }

        public void deleteCard(Card entity)
        {
            var messageBoxMitOptions = new MsgBoxWithOptions("Möchten Sie diese Karteikarte löschen?");
            var result = messageBoxMitOptions.ShowDialog();
            if (result == true)
            {
                cardRepository.delete(entity);
                GetAll();
            }
        }

        public void sortCardsWithComboBox(Category selectedCategory)
        {
            this.selectedCategory = selectedCategory;
            GetAll();
        }
        
    }
}
