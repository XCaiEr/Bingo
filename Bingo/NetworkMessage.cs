using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;  

namespace Bingo
{
    class NetworkMessage
    {
        static Socket clientSocket;

        void OnMessage()
        {

        }

        void SendLogonMsg(string sAccName, string sPassword)
        {
        }

        public static void DoWork()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3001);
            clientSocket = new Socket(ipep.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                clientSocket.Connect(ipep);
                Byte[] inBuffer = new Byte[1024];
                while (true)
                {
                    //发送消息   
                    //outBufferStr = Console.ReadLine();
                    //outBuffer = Encoding.ASCII.GetBytes(outBufferStr);
                    //clientSocket.Send(outBuffer, outBuffer.Length, SocketFlags.None);

                    //接收服务器端信息
                    clientSocket.Receive(inBuffer, 1024, SocketFlags.None);
                }
            }
            catch
            {
                Console.WriteLine("服务未开启！");
            }
        }
    }
}
