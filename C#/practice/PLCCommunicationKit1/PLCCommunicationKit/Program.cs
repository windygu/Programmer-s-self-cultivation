﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using PLCCommunicationKit.SocketBaseKit;

namespace PLCCommunicationKit
{
    class Program
    {
        static void Main(string[] args)
        {
            // SocketBase.SocketBase sk = new SocketBase.SocketBase();
            SocketBase sk = new SocketBase();
            // skd = new Socket();
            Console.Write("ok");
            sk.CreatandConnect("172.16.8.204", 102);
            string ina = Console.ReadLine();
            //Console.ReadKey();
            byte[] by = Encoding.UTF8.GetBytes(ina);
            //Socket soc=null;
            sk.SocketSend(by);
            Thread.Sleep(10);
            Console.WriteLine(sk.SocketRec());
            Console.ReadKey();

        }

    }
}