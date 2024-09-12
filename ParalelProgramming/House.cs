namespace ParalelProgramming
{
    public class House
    {
        private int Id;
        public House(int id)
        {
            Id = id;
        }
        public void Remontis_Gaketeba()
        {
            Milebis_Gayvana();
            Eleqtroobis_Gayvana();
            Gajit_Galisva();
            Maliaris_Saqme();
            Console.WriteLine($"mzadaa bina N:{Id}");
        }
        private void Milebis_Gayvana()
        {
            var random = new Random();
            var number = random.Next(200, 500);
            Thread.Sleep(number);
        }
        private void Eleqtroobis_Gayvana()
        {
            var random = new Random();
            var number = random.Next(200, 500);
            Thread.Sleep(number);
        }
        private void Gajit_Galisva()
        {
            var random = new Random();
            var number = random.Next(200, 500);
            Thread.Sleep(number);
        }
        private void Maliaris_Saqme()
        {
            var random = new Random();
            var number = random.Next(200, 500);
            Thread.Sleep(number);
        }
    }
}
