// See https://aka.ms/new-console-template for more information
namespace modul8_1302210046
{
    public class Program
    {
        private static void Main(string[] args)
        {
            BankTransferConfig bank = new BankTransferConfig();
            Console.WriteLine(bank.bank = "en" ? "Please insert the amount of money to transfer:" : "Masukkan jumlah uang yang akan di-transfer:");
            int amount = int.Parse(Console.ReadLine());

            int transferfee1 = amount <= bank.transfer.low_fee;
            int transferfee2 = amount >= bank.transfer.high_fee;

            Console.WriteLine(bank.bank == "en" ? "Select transfer method:" : "Pilih metode transfer:")

            if (confirmation == bank.Confirmation.en || confirmation == bank.Confirmation.id)
            {
                Console.WriteLine(bank.bank == "en" ? "The transfer is completed" : "Proses transfer berhasil");
            }
            else {
                Console.WriteLine(bank.bank == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
            }
        }
    }
}