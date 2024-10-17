using System;

public class Computer
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string CoreType { get; set; }
    public int CoreHz { get; set; }
    public int AmountOfRAM { get; set; }
    public int HardDriveCapacity { get; set; }
    public int VideocardMemoryCapacity { get; set; }
    public decimal Price { get; set; }
    public int NumInStock { get; set; }

    public override string ToString() => $"Номер: {Id}, Бренд: {Brand}, Тип процессора: {CoreType}, " +
        $"Герцовка процессора: {CoreHz}, Объем оперативной памяти: {AmountOfRAM}, " +
        $"Объем памяти диска: {HardDriveCapacity}, Объем видеопамяти: {VideocardMemoryCapacity}, " +
        $"Цена: {Price}, В наличие, шт: {NumInStock}";
}


