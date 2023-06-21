using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double bs, hra, ta, da, pf, gross;
        private static int count;
        public Employee(string name, double bs)
        {
            count++;
            id = count;
            this.name = name;
            this.bs = bs;
        }

        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            da = bs * 0.15;
            pf = bs * 0.12;
            gross = (bs + hra + ta + da) - pf;
        }
        public override string ToString()
        {
            return $"id={id}, name={name}, gross ={gross}";
        }
    }

    public class SalesManager : Employee
    {
        private double comm;
        
        public SalesManager(string name, double bs, double comm) : base(name, bs) //parametric constructor
        {
            this.comm = comm;

        }
        public override void CalculateSalary()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            da = bs * 0.15;
            pf = bs * 0.12;
            gross = (bs + hra + ta + da + comm) - pf;
        }
        
        public override string ToString()
        {
            return $"id={id}, name={name}, gross ={gross}";
        }

    }
}
