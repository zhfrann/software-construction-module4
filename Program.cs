using System.Reflection;

class KodeProduk
{
    private string[] namaProduk = { "Laptop", "Smarthphone", "Tablet", "Headset", "Keyboard", "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera" };
    private string[] kodeProduk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };

    public string getKodeProduk(string namaProduk)
    {
        int idxProduk = Array.IndexOf(this.namaProduk, namaProduk);
        return kodeProduk[idxProduk];
    }
}

class FanLaptop
{
    public enum State { Quiet, Balanced, Performance, Turbo };

    private State state = State.Quiet;
    
    public void SetState()
    {
        int stateValue = (int)this.state;
        int nextState = 0;

        while (stateValue != 9)
        {
            if (stateValue == 0)
            {
                // Quiet
                Console.Write($"\n[Status Saat ini: {stateValue}|{this.state}] Pilih mode kipas laptop: ");
                Console.WriteLine("[1] Balanced   [3] Turbo   [9] Exit");
                Console.Write("> Menu: ");
                nextState = Int32.Parse(Console.ReadLine());

                if (nextState == 1)
                {
                    stateValue = 1; // Set to Balanced
                    this.state = State.Balanced;
                    Console.WriteLine($"Fan {this.state} berubah menjadi Balanced");
                }
                else if (nextState == 3)
                {
                    stateValue = 3; // Set to Turbo
                    this.state = State.Turbo;
                    Console.WriteLine($"Fan {this.state} berubah menjadi Turbo");
                }
                else if (nextState == 9)
                {
                    stateValue = 9; // Exit
                    Console.WriteLine($"~ ~ Exit");
                    break;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid, silakan coba lagi.");
                }
            }
            else if (stateValue == 1)
            {
                // Balanced
                Console.Write($"[Status Saat ini: {stateValue}|{this.state}] Pilih mode kipas laptop: ");
                Console.WriteLine("[0] Quiet   [2] Performance   [9] Exit");
                Console.Write("> Menu: ");
                nextState = Int32.Parse(Console.ReadLine());

                if (nextState == 0)
                {
                    stateValue = 0; // Set to Quiet
                    this.state = State.Quiet;
                    Console.WriteLine($"Fan {this.state} berubah menjadi Quiet");
                }
                else if (nextState == 2)
                {
                    stateValue = 2; // Set to Performance
                    this.state = State.Performance;
                    Console.WriteLine($"Fan {this.state} berubah menjadi Performance");
                }
                else if (nextState == 9)
                {
                    stateValue = 9; // Exit
                    Console.WriteLine($"~ ~ Exit");
                    break;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid, silakan coba lagi.");
                }
            }
            else if (stateValue == 2)
            {
                // Performance
                Console.Write($"[Status Saat ini: {stateValue}|{this.state}] Pilih mode kipas laptop: ");
                Console.WriteLine("[1] Balanced   [3] Turbo   [9] Exit");
                Console.Write("> Menu: ");
                nextState = Int32.Parse(Console.ReadLine());

                if (nextState == 1)
                {
                    stateValue = 1; // Set to Balanced
                    this.state = State.Balanced;
                    Console.WriteLine($"Fan {this.state} berubah menjadi Balanced");
                }
                else if (nextState == 3)
                {
                    stateValue = 3; // Set to Turbo
                    this.state = State.Turbo;
                    Console.WriteLine($"Fan {this.state} berubah menjadi Turbo");
                }
                else if (nextState == 9)
                {
                    stateValue = 9; // Exit
                    Console.WriteLine($"~ ~ Exit");
                    break;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid, silakan coba lagi.");
                }
            }
            else if (stateValue == 3)
            {
                // Turbo
                Console.Write($"[Status Saat ini: {stateValue}|{state}] Pilih mode kipas laptop: ");
                Console.WriteLine("[2] Performance   [0] Quiet   [9] Exit");
                Console.Write("> Menu: ");
                nextState = Int32.Parse(Console.ReadLine());

                if (nextState == 2)
                {
                    stateValue = 2; // Set to Performance
                    state = State.Performance;
                    Console.WriteLine($"Fan {state} berubah menjadi Performance");
                }
                else if (nextState == 0)
                {
                    stateValue = 0; // Set to Quiet
                    state = State.Quiet;
                    Console.WriteLine($"Fan {state} berubah menjadi Quiet");
                }
                else if (nextState == 9)
                {
                    stateValue = 9; // Exit
                    Console.WriteLine($"~ ~ Exit");
                    break;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid, silakan coba lagi.");
                }
            }
            else if (stateValue == 9)
            {
                //Exit
                break;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodeProduk kodeProduk = new KodeProduk();
       
        Console.WriteLine("=== Program Kode Produk dan Fan Laptop ===");
        Console.Write("Masukkan nama produk: ");
        string namaProduk = Console.ReadLine();
        string kode = kodeProduk.getKodeProduk(namaProduk);
        Console.WriteLine($"Kode produk untuk {namaProduk} adalah: {kode}");

        FanLaptop fanLaptop = new FanLaptop();
        Console.WriteLine("\n=== Pengaturan Fan Laptop ===");
        fanLaptop.SetState();
    }
}