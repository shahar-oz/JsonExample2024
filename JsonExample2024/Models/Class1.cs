﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonExample2024.Models
{

    public class MonkeyList
    {
        public List<Monkey> Monkeys { get; set; }

        public void CreateList()
        {
            string text = File.ReadAllText(@"../../../monkeydata.json");
            Monkeys = JsonSerializer.Deserialize<List<Monkey>>(text);
        }

        public MonkeyList()
        {
            Monkeys = new List<Monkey>();
            CreateList();
        }

    }

    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public int Population { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }

    public class Rootobject
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public int Population { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }



}
