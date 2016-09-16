using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingclasseshomework
{
    class Book
    {

        //instance variables
        private string title; 
        private string author;
        private int pages;
        private int wordcount;

        //contructor (has same name as class) method user providing books title
        public Book(string title)
              {
                this.title = title;  //allow to access the instance variable (above)                            
              }


        // methods
       
            
        public void SetTitle(string title)
              {
                 this.title = title;
              }
        public string GetTitle()
              {
                  return title;
              }
        public void AssignWordCountFromText(string text)
             {
               wordcount = text.Split(' ').Length;
             }


    }
}
