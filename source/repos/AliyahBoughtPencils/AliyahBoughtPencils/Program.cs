using System;

namespace AliyahBoughtPencils
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aliyah had \$24 to spend on seven pencils. After buying them she had 10. How much did each pencil cost?

            int inWallet = 24;
            int afterBuyingPencils = 10;
            int numberOfPencils = 7;
            int totalCostOfPencils = inWallet - afterBuyingPencils;
            int costPerPencil = totalCostOfPencils / numberOfPencils;
            Console.WriteLine("Aliyah spent $" + costPerPencil + " per pencil.");
        }
    }
}
