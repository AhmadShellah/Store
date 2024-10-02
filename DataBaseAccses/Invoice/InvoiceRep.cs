using Objects.Dtos.ProductDtos;
using Objects.Models;
using Objects.Models.InvoiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccses.Invoice
{
    public class InvoiceRep
    {
        private readonly static List<InvoiceEntity> _invoiceEntitys = new();


        public InvoiceModel Create(InvoiceModel inputFromDevelopers)
        {
            var modelToDataBaseModel = new InvoiceEntity()
            {
                Number = inputFromDevelopers.Number,
                PersonName = inputFromDevelopers.PersonName,
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Test",
                        Price = 50,
                    },
                      new Product()
                    {
                        Name = "YYY",
                        Price = 100,
                    },
                     new Product()
                    {
                        Name = "VVV",
                        Price = 500,
                    }
                }
            };

            _invoiceEntitys.Add(modelToDataBaseModel);

            var dataBaseModelToModel = new InvoiceModel()
            {
                Number = modelToDataBaseModel.Number,
                PersonName = modelToDataBaseModel.PersonName,
                Products = new List<ProductModel>()
                {
                    new ProductModel()
                    {
                        Name = "Test",
                        Price = 50,
                    },
                      new ProductModel()
                    {
                        Name = "YYY",
                        Price = 100,
                    },
                     new ProductModel()
                    {
                        Name = "VVV",
                        Price = 500,
                    }
                }
            };

            return dataBaseModelToModel;
        }

        public List<InvoiceModel> GetAll()
        {
            var result = _invoiceEntitys.Select(c => new InvoiceModel()
            {
                Id= c.Id,
                DueDate = c.DueDate,
                Number = c.Number,
                PersonName = c.PersonName,
                Products = new List<ProductModel>()
                {
                   new ProductModel()
                    {
                        Name = "Test",
                        Price = 50,
                    },
                      new ProductModel()
                    {
                        Name = "YYY",
                        Price = 100,
                    },
                     new ProductModel()
                    {
                        Name = "VVV",
                        Price = 500,
                    }
                }
            }).ToList();

            return result;
        }
    }
}
