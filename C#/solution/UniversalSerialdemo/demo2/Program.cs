﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;

namespace serialdemo2   //demo2
{
    public class Serialdemo
    {
        //实例
        private static SerialPort myserial=null; 
        //接收
        public static void ReceiveDataThread()
        {
            while (true)
            {
                    int n = myserial.BytesToRead;
                if (n > 0)
                {
                    byte[] rec = new byte[n];
                    myserial.Read(rec, 0, n);
                    string str = Encoding.Default.GetString(rec);
                    Console.WriteLine("接收到信息: {0}", str);
                    Thread.Sleep(50);
                }
                //return rec;
            }

        }
        public static void SendDataTH() //接收发送 均以字节形式
        {
            while (true)
            {
                Console.Write("plz inout: ");
                string inputstr = Console.ReadLine();
                byte[] inputstr1 = Encoding.Default.GetBytes(inputstr);
                myserial.Write(inputstr1, 0, inputstr1.Length);
                //Console.WriteLine("send: {0}", inputstr);
                Thread.Sleep(50);
            }
        }

        //public void configsetting()
        //{
        //    myserial.PortName = "com2";
        //    myserial.BaudRate = 115200;
        //    myserial.DataBits = 8;
        //    myserial.StopBits = StopBits.One;
        //}
        //public static void threadstart()
        //{
        //    Thread recthread = new Thread(ReceiveDataThread);
        //    Thread sendthread = new Thread(SendDataTH);
        //    if (recthread != null)
        //    {
        //        recthread.Start();
        //    }
        //    if (sendthread != null)
        //    {
        //        sendthread.Start();
        //    }
            //while (true)
            //{
            //    Thread.Sleep(100);
            //}
        //}



        static void Main(string[] args)
        {
            //Serialdemo myserialinstance = new Serialdemo();
            myserial = new SerialPort();

            myserial.PortName = "com1";
            myserial.BaudRate = 9600;
            myserial.DataBits = 8;
            myserial.StopBits = StopBits.One;
            myserial.Parity = Parity.Even;
            //myserial.ReadTimeout = 5000;
            myserial.Encoding = Encoding.GetEncoding("utf-8");
            myserial.Open();
            if (myserial.IsOpen)
            {
                Console.WriteLine("串口打开成功..");
            }
            else
            {
                Console.WriteLine("串口打开失败..");
            }


            //threadstart();
            // 启动接收线程
            Thread th11 = new Thread(ReceiveDataThread);
            if (th11 != null)
                th11.Start();

            // 启动发送线程
            Thread th22 = new Thread(SendDataTH);
            if (th22 != null)
                th22.Start();
            while (true)
            {
                Thread.Sleep(100);
            }
        }
    }
}



