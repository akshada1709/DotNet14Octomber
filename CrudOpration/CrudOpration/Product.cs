//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CrudOpration
//{
//    //Entity Class
//    public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Price {  get; set; }

//        public override string ToString()
//        {
//            return $"Id={Id},Name={Name},Price{Price}";
//        }
//    }

     

//    //manage product to create another class
//    public class ProductCrud 
//    {
//        List<Product> products;

//        public ProductCrud()
//        {
//            products = new List<Product>();
//        }

//        public void AddProducts(Product prd) ////pass Product obj because we add in Product
//        {
//            products.Add(prd);
        
//        }

//        public void ModifyProduct(Product prd) 
//        {
            
//                for (int i = 0; i < products.Count; i++)
//                {
//                    if (products[i].Id == prd.Id)
//                    {
//                    products[i].Name = prd.Name;
//                    products[i].Price = prd.Price;
//                     break;
//                    }
//                }
            

//        }

//        public void DeleteProduct(int id) 
//        {
//            for (int i = 0; i < products.Count; i++) 
//            {
//                if (products[i].Id == id) 
//                {
//                   products.Remove(products[i]);//both way usefull
//                    //products.RemoveAt(i);
//                    break;
//                }
//            }
//        }

//        //return list so method return data-type is list data-type. i.e List<Product>
//        public List<Product> ProductList() 
//        {
//            return products; 
//        }

        
//        public Product GetProductById(int id) 
//        {
//            //create product to hold data
//            Product p=new Product();
//            foreach (var item in products)
//            {
//                if(item.Id == id) 
//                {
//                   p.Id = item.Id;
//                    p.Name = item.Name;
//                    p.Price = item.Price;
//                }
                
//            }
//            return p;
//        }

//    }
//}
