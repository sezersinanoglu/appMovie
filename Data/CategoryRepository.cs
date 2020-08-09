﻿using appMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appMovie.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;
        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                   new Category() { Id=1,Name="Macera"},
                   new Category() { Id=2,Name="Romantik"},
                   new Category() { Id=3,Name="Bilim - Kurgu"},
                   new Category() { Id=4,Name="Aksiyon"},
                   new Category() { Id=5,Name="Polisiye Macera"},
            };

        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }

        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(x => x.Id == id);
        }
    }

}