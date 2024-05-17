using MyCards.Models;
using MyCards.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCards.ViewModels
{
    internal class AddCardViewModel : BaseViewModel
    {
        private CardRepository cardRepository;
        private CategoryRepository categoryRepository;
        private Category myCategory;
        public Category MyCategory { get { return myCategory; } set { myCategory = value; OnPropertyChanged(nameof(myCategory)); } }
        private Card myCard;
        public Card MyCard { get { return myCard; } set { myCard = value; OnPropertyChanged(nameof(myCard)); } }
        private List<Category> categories;
        public List<Category> Categories { get { return categories; } set { categories = value; OnPropertyChanged(nameof(categories)); } }
        public AddCardViewModel() {
            MyCategory = new Category();
            MyCard = new Card();
            cardRepository = new CardRepository();
            categoryRepository = new CategoryRepository();
            categories = categoryRepository.GetAllWithoutAlle();
        }
        public void addCard()
        {
            MyCard.CategoryId = MyCategory.Id;
            cardRepository.Add(MyCard);
            MyCard = new Card();
        }
    }
}
