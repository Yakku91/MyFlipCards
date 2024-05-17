using MyCards.MessageBoxes;
using MyCards.Models;
using MyCards.Repository;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Windows;

namespace MyCards.ViewModels
{
    internal class CategoryViewModel : BaseViewModel
    {
        private CategoryRepository categoryRepository;
        private Category category;
        public Category myCategory { get { return category; } set { category = value; OnPropertyChanged(nameof(myCategory)); } }
        private List<Category> categories;
        public List<Category> Categories { get { return categories; } set { categories = value; OnPropertyChanged(nameof(Categories)); } }

        public CategoryViewModel() 
        {
            myCategory = new Category();
            categoryRepository = new CategoryRepository();
            Categories = new List<Category>();
            getAll();
        }
        private void getAll()
        {
            Categories = categoryRepository.GetAllWithoutAlle();
            Categories.OrderByDescending(e => e.Id);
        }
        public void editCategory(Category category)
        {
            new DialogBoxEditCategory(category).Show();
            getAll();
        }
        public void addCategory()
        {   
            myCategory.UserId = App.currentUser.Id;
            try
            {
                categoryRepository.Add(myCategory);
                getAll();
                myCategory = new Category();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
