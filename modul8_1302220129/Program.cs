namespace a
{
    class BankTransferConfig
    {
        public BankTransferConfig config;
        private string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private string fileName = "bank_transfer_config.json";

        public BankTransferConfig()
        {

        }
        private BankTransferConfig;
        private void SetDefaultConfig;
        private void WriteNewBTConfigFile;
    }

    class Program
    {
        static void main(string[] args)
        {
            int biayatf = 0;
            int nominaltf = 0;
            UIConfig uiconfig = new UIConfig();
            if (uiconfig.config.lang == "en") {
                Console.WriteLine("Please insert the amount of money to transfer: ");
                Console.WriteLine("Transfer fee = ", "<biayatf>", " and Total amount = ", "<nominaltf + biayatf");
            } else
            {
                Console.WriteLine("masukkan jumlah uang yang akan di-transfer")
                Console.WriteLine("biaya transfer = ", "<biayatf>", " dan total biaya = ", "<nominaltf + biayatf>)
            }
        }
    }
}