using System;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using BoardTCPHandle4._8;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.IO;

namespace DllHandle
{
    class Program
    {
        static async Task Main(string[] args)
        {
            TcpClientHandler.CreatSocket(new {index = 0,ipAddress = "192.168.0.100",port = 5000});
            Console.WriteLine(await TcpClientHandler.CheckBoard(new { index = 0 }));
            Console.WriteLine(await TcpClientHandler.InitBoard(new { Address = "192.168.0.100:5000" }));
            TcpClientHandler.Socket[0].Client.Close();
        }
    }

    class Function
    {
        public static void LotusCardDriverHandle()
        {
            string dllPath = "LotusCardDriverHandle4.8.dll";

            Assembly assembly = Assembly.LoadFrom(dllPath);

            Type DllClass = assembly.GetType("LotusCardDriverHandle.MainHandle");

            if (DllClass != null)
            {
                object DllInstance = Activator.CreateInstance(DllClass);

                // 获取DLL中的方法信息
                MethodInfo DllMethod = DllClass.GetMethod("LotusCardGetCardNo");

                if (DllMethod != null)
                {
                    // 调用DLL中的方法
                    object[] parameters = { };
                    string result = (string)DllMethod.Invoke(DllInstance, parameters);

                    // 输出结果
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Method  not found in Class");
                }
            }
            else
            {
                Console.WriteLine("Class not found in the assembly");
            }

        }
        public static void SCUCupBoardHandle()
        {
            string dllPath = "SCUCupBoardHandle4.8.dll";

            Assembly assembly = Assembly.LoadFrom(dllPath);

            Type DllClass = assembly.GetType("SCUCupBoardHandle4._8.SCUCupBoardHandle");

            if (DllClass != null)
            {
                object DllInstance = Activator.CreateInstance(DllClass);

                // 获取DLL中的方法信息
                MethodInfo DllMethod = DllClass.GetMethod("OpenBox");

                if (DllMethod != null)
                {
                    // 调用DLL中的方法
                    object[] parameters = { 1, 1 };
                    string result = (string)DllMethod.Invoke(DllInstance, parameters);

                    // 输出结果
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Method  not found in Class");
                }
            }
            else
            {
                Console.WriteLine("Class not found in the assembly");
            }

        }
    }
}