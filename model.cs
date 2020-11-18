using System;
using System.Collections.Generic;



namespace RepveUOW.Data.Model
{
    public abstract class ModelBase
    {
        public DateTime CreatedDate { get; set; }
    }
    public class Article : ModelBase 
    {
        public Article()
        {
            //this.Articles = new List();
        }
    }
    public class User : ModelBase
    {
        public User()
        {
           // this.Articles = new List();
        }
       

       
        public int Id { get; set; }
        public string FirstName { get;set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        
        public virtual ICollection<Article>  Articles { get; set; }
        
    }
} 
