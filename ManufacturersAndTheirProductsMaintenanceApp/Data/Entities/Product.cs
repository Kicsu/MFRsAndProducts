﻿using System;

namespace ManufacturersAndTheirProductsMaintenanceApp.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public byte[] Image { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime LastChangedDateTime { get; set; }

        public Guid LastChangedBy { get; set; }
    }
}
