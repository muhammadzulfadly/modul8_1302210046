using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace modul8_1302210046
{
    public class BankTransferConfig
    {
        public Bank bank { get; set; }
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public string configFileName = "bank_transfer_config.json";

        public BankTransferConfig()
        {
            try
            {
                ReadConfig();
            }
            catch
            {
                SetDefault();
                WriteConfig();
            }
        }

        private Bank ReadConfig()
        {
            string jsonFromFile = File.ReadAllText(path + '/' + configFileName);
            bank = JsonSerializer.Deserialize<Bank>(jsonFromFile);
            return bank;
        }

        private void WriteConfig()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String jsonString = JsonSerializer.Serialize(bank, options);
            string fullPath = path + '/' + configFileName;
            File.WriteAllText(fullPath, jsonString);
        }

        private void SetDefault()
        {
            bank = new Bank("en", 25000000, 6500, 15000, ["RTO(real-time)", "SKN", "RTGS", "BI FAST"], "yes", "ya");
        }


        public class Bank
        {
            public string lang { get; set; }
            public Transfer transfer { get; set; }
            public string method { get; set; }
            public Confirmation confirmation { get; set; }
            public Bank(string lang, Transfer transfer, string method, Confirmation confirmation)
            {
                this.lang = lang;
                this.transfer = transfer;
                this.method = method;
                this.confirmation = confirmation;
            }
         }

        public class Transfer
        {
            public int en { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
            public Transfer(int en, int low_fee, int high_fee)
            {
                this.en = en;
                this.low_fee = low_fee;
                this.high_fee = high_fee;
            }
        }

        public class Confirmation
        {
            public string en { get; set; }
            public string id { get; set; }
            public Confirmation(string en, string id)
            {
                this.en = en;
                this.id = id;
            }
        }
    }
}