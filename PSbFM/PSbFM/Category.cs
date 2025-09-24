using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSbFM
{
    public class Category
    {
        public List<string> CategoryList = new List<string>();
        public string name = "Shopping";
        public Category() {
            CategoryList.Append("Food");
            CategoryList.Append($"Transport");
            CategoryList.Append($"Money transfer");
            CategoryList.Append($"Shopping");
            CategoryList.Append($"Sub");
            CategoryList.Append($"Health");
            CategoryList.Append($"Entertainment and relaxation");
        }
         public void ChangeCategory(int index)
        {
           name = CategoryList[index-1];
        } 
        public void AddCategory( string newCategory)
        {
            CategoryList.Append($"{newCategory}"); 
        }





    }
        
    
}
