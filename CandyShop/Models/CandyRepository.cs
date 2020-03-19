using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Candy> GetAllCandy => new List<Candy>
        { 
        new Candy{CandyId = 1, Name = "Assorted Hard Candy", Price = 4.95M, Description = "Lorem ipsum",
            Category = _categoryRepository.GetAllCategories.ToList()[0],
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/13/HardCandy.jpg",
            IsInStock = true, IsOnSale=false,ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/1/13/220px-HardCandy.jpg"
            },
        new Candy{CandyId = 1, Name = "Chocolate Candy", Price = 5.95M, Description = "Lorem ipsum",
            Category = _categoryRepository.GetAllCategories.ToList()[1],
            ImageUrl = "https://en.wikipedia.org/wiki/Chocolate#/media/File:Chocolate_(blue_background).jpg",
            IsInStock = true, IsOnSale=false,ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/7/70/Chocolate_%28blue_background%29.jpg"
            },
        new Candy{CandyId = 1, Name = "Assorted Fruit Candy", Price = 3.95M, Description = "Lorem ipsum",
            Category = _categoryRepository.GetAllCategories.ToList()[2],
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Betty_Crocker_Fruit_Gushers_pieces.jpg",
            IsInStock = true, IsOnSale=false,ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Betty_Crocker_Fruit_Gushers_pieces.jpg/320px-Betty_Crocker_Fruit_Gushers_pieces.jpg"
            }
        };
        public IEnumerable<Candy> GetCandyOnSale => throw new NotImplementedException();
        
        public Candy GetCandyById(int candyId)
        {
        return GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}
