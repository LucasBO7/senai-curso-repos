using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio
{
    public class Student
    {
        public string Name { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }
        public int RG { get; set; }
        public bool IsScholarshipStudent { get; set; } // É bolsista?
        public float FinalAverage { get; set; } // Média final
        public float MonthlyFee { get; set; } // Valor da mensalidade
        public float Discount { get; set; }

        // Mostrar média final
        public void ShowFinalAverage(Student student, float finalAverage)
        {
            Console.WriteLine($"Média final: {finalAverage}");
            Console.ReadLine();
            Console.Clear();
        }

        // Mostrar mensalidade
        public void ShowMonthlyFee(Student student, float monthlyFee)
        {
            Console.WriteLine($"Mensalidade: R$ {monthlyFee.ToString("F2")}");
            Console.ReadLine();
            Console.Clear();
        }

        public float CalculateDiscount(bool isStudentScholarship, float finalAverage, float monthlyFee)
        {
            // Se aluno for bolsista e média maior que 6
            if (isStudentScholarship == true && finalAverage > 6)
            {
                if (finalAverage >= 8)
                {
                    this.Discount = 0.5f; // 0.5 = 50% em decimal
                }
                else
                {
                    this.Discount = 0.3f;
                }
                float discountValue = monthlyFee * this.Discount; // Pega o valor correspondente à porcentagem
                monthlyFee = monthlyFee - discountValue; // Subtrai para retornar o valor final com o desconto
            }
            return monthlyFee;
        }
    }
}