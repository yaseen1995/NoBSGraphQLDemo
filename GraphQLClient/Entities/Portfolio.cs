﻿using System.Collections.Generic;

namespace GraphQLClient.Entities
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public ICollection<Stock> Stocks = new List<Stock>();
    }
}