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

        public void CalculateDiscount(bool isStudentScholarship, float finalAverage, float monthlyFee, float discount)
        {
            // Se aluno for bolsista e média maior que 6
            if (isStudentScholarship && finalAverage > 6)
            {
                if (finalAverage >= 8)
                {
                    discount = 0.5f; // 0.5 = 50% em decimal
                }
                else
                {
                    discount = 0.3f;
                }
                monthlyFee = monthlyFee * discount;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O aluno não possui acesso ao desconto.");
                Console.ResetColor();
            }
        }
    }
}