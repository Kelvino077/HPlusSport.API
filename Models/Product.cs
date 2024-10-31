using System.Text.Json.Serialization;
namespace HPlusSport.API.Models
{
    public class Product
    {
        public int id {get; set;}
        public string Name {get; set;} =  string.Empty;
        public string Description {get;set;} = string.Empty;
         public decimal price {get; set;}
        public bool isAvailable {get;set;}
        public int CategoryategoryId {get;set;}
        [JsonIgnore]
        public virtual Category Category {get; set;}



    }
}