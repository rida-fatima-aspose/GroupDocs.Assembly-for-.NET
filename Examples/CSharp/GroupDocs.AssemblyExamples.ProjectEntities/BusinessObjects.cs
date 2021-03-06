﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GroupDocs.AssemblyExamples.ProjectEntities
{
    public class BusinessObjects
    {
        public static string imagePath = "../../../../Data/Images/";
        public static string docPath = "../../../../Data/OuterDocuments/";

        //ExStart:ProjectEntities
        public class Customer
        {
            public String CustomerName { get; set; }
            public string ShippingAddress { get; set; }
            public string CustomerContactNumber { get; set; }
            public IEnumerable<Order> Order { get; set; }
            public string Barcode { get; set; }
            public String Photo { get { return Path.Combine(Path.GetFullPath(imagePath), "no-photo.jpg"); } }
            public string Document { get { return Path.Combine(Path.GetFullPath(docPath), "outerDoc.odt"); } } 
 
        }
        public class Order
        {
            public Customer Customer { get; set; }
            public Product Product { get; set; }
            public int ProductQuantity { get; set; }
            public int Price { get; set; }
            public string Barcode { get; set; }
            public DateTime OrderDate { get; set; }
            public int OrderNumber { get; set; }
            public DateTime ShippingDate { get; set; }
        }
        public class Product
        {
            public string ProductName { get; set; }
            public int UnitInStock { get; set; }
            public int Discount { get; set; }
            public string ProductPrice { get; set; }
        }
        //ExEnd:ProjectEntities
    }
}
