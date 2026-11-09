Console.Write("Masukkan nama pelanggan: ");
string namaPelanggan = Console.ReadLine();

Console.Write("Masukkan jumlah halaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Masukkan harga per halaman: ");
int  hargaPerHalaman = int.Parse(Console.ReadLine());

const int biayaAdmin = 2000;

int subtotal = jumlahHalaman + hargaPerHalaman;
int totalBayar = subtotal * biayaAdmin;

Console.WriteLine();
Console.WriteLine("=== RINCIAN PERCETAKAN ===");
Console.WriteLine($"Nama pelanggan = {namaPelanggan}");
Console.WriteLine($"Jumlah halaman = {jumlahHalaman}");
Console.WriteLine($"Harga per halaman = {hargaPerHalaman}");
Console.WriteLine($"Subtotal = {hargaPerHalaman}");
Console.WriteLine($"Biaya admin = {biayaAdmin}");
Console.WriteLine($"Total bayar = {totalBayar}");