using System;
using EasyModbus;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ModbusClient modbusClient = new ModbusClient("10.0.2.134", 502);
            modbusClient.Connect();

            bool[] readCoils = modbusClient.ReadCoils(196, 1);
            int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(196, 1);

            for (int i = 0; i < readCoils.Length; i++)
                Console.WriteLine("Value of Coil " + (9 + i + 1) + " " + readCoils[i].ToString());

            for (int i = 0; i < readHoldingRegisters.Length; i++)
                Console.WriteLine("Value for HoldingRegister " + (i + 1) + " " + readHoldingRegisters[i].ToString());

            // TODO: Logic will go here

            Console.Write("Press any key to continue ...");
            Console.ReadKey(true);

            Console.ReadKey(true);
        }
    }
}
