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