﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        private int id;
        private static int nextId = 1;
        private string value;

        // TODO: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            //id = nextId;
            //nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return value;
        }
    }
    }
}
