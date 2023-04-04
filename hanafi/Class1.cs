using System;

class Mobil
{
    // Field
    private string _warna;
    private int _jumlahPintu;
    private string _merek;
    private string _model;
    private int _tahunKeluaran;

    // Properties
    public string warna
    {
        get { return _warna; }
        set { _warna = value; }
    }

    public int jumlahPintu
    {
        get { return _jumlahPintu; }
        set { _jumlahPintu = value; }
    }

    public string merek
    {
        get { return _merek; }
        set { _merek = value; }
    }

    public string model
    {
        get { return _model; }
        set { _model = value; }
    }

    public int tahunKeluaran
    {
        get { return _tahunKeluaran; }
        set { _tahunKeluaran = value; }
    }

    // Method
    public void gas(int kecepatan)
    {
        Console.WriteLine("Mobil " + model + " berjalan dengan kecepatan " + kecepatan);
    }

    public void klakson(string suara)
    {
        Console.WriteLine(suara + "!");
    }

    public void tampilkanInfo()
    {
        Console.WriteLine("Mobil saya berwarna " + warna + ", merek " + merek + " model " + model + " keluaran tahun " + tahunKeluaran + " dengan jumlah pintu sebanyak " + jumlahPintu);
    }
}