using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Linq;
using System.IO;
using System.Configuration;
using System.Reflection;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Net;

namespace ConsoleApp4

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string message = "0000600210806701       ULUWAS15V      20230118120010001212000P200000560210800701       ULUWAS15V      202301181200100008Se011110000560210800701       ULUWAS15V      202301181200100008Se200210000560210800701       ULUWAS15V      202301181200100008Se505910000560210800701       ULUWAS15V      202301181200100008Se204810000560210800701       ULUWAS15V      202301181200100008Se505900000560210800701       ULUWAS15V      202301181200100008Se011010000560210800701       ULUWAS15V      202301181200100008Se011210000560210800701       ULUWAS15V      202301181200100008Se204610000560210800701       ULUWAS15V      202301181200100008Se200010000560210800701       ULUWAS15V      202301181200100008Se200410000560210800701       ULUWAS15V      202301181200100008Se01110";
                int port = 11000;

                IPAddress ipAddress = IPAddress.Parse("10.22.6.33");

                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                sender.Connect(remoteEP);

                Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

                byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);

                int bytesSent = sender.Send(msg);

                Console.WriteLine("Message sent to the server : {0}", message);

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            // Replace "message" with your actual JSON string
            //string message = "{ \"MESSAGE_TYPE\":\"STATUS\",\"ACTIVITY_TYPE\":\"TERMINAL_NATIVE \",\"COMMON_CONTENT\":{ \"MESSAGE_LENGTH\":\"0464\",\"TSTAMP_HOST\":\"2022101103013688 \",\"ID_TERMINAL\":\"2L10\",\"DATE_TERMINAL\":\"20221011\",\"TIME_TERMINAL\":\"030136\",\"RESPONSE_HOST\":\"                                                            \"},\"SHARED_CONTENT\":{ \"LU_NAME\":\" 10. 46.181. 69\",\"HOST_IMAGE\":\"  \",\"HOST_TASK\":\"THANAB4 \"},\"NATIVE_CONTENT\":{ \"NATIVE_DATA\":\"12 000123456  w3   ! !                                                                                                                                                 \" \"  4 04042FB11F04021000000000902F\"}}";
            //int index = message.LastIndexOf("\":\"");
            //Console.WriteLine(message);
            //for(var i = index + 3; i < message.Length-4; i++)
            //{
            //    if (message[i] == '"')
            //    {
            //        Console.WriteLine(message[i]);
            //        Console.WriteLine("matched");
            //        message.Remove(i, 2);
            //        var aStringBuilder = new StringBuilder(message);
            //        aStringBuilder.Remove(i, 1);
            //        aStringBuilder.Insert(i, " ");
            //        message = aStringBuilder.ToString();
            //    }
            //}
            //Console.WriteLine("Corrected message: " + message);
            //Console.WriteLine("index: " + index);
            //string deviceID = "12345678";
            //Console.WriteLine(deviceID.Substring(deviceID.Length - 4, 1));
            //Console.WriteLine(message);
            //// Split the JSON string into an array of characters
            //char[] jsonChars = message.ToCharArray();

            //// Find the position of the last comma in the JSON string
            //int lastCommaPos = jsonChars.Length - 4;
            //while (jsonChars[lastCommaPos] != '"')
            //{
            //    lastCommaPos--;
            //}

            //// Remove the last comma from the JSON string
            //jsonChars = jsonChars.Take(lastCommaPos).Concat(jsonChars.Skip(lastCommaPos + 1)).ToArray();

            //// Rebuild the JSON string from the modified array of characters
            //string fixedJson = new string(jsonChars);

            //// Print the fixed JSON string
            //Console.WriteLine(fixedJson);
            //Console.ReadKey();
            //string[] returnValues = message.Split('"NATIVE_DATA":"');
            // int s = message.IndexOf("NATIVE_DATA\":\"");
            //string[] brokenMsg = message.Substring("NATIVE_DATA\":\"");
            // string filter = brokenMsg[1];
            // Console.WriteLine(brokenMsg[1]);
            //for(var i = brokenMsg[1].Length - 4; i<= 0;i--)
            // {
            //     if(filter[i] == '"')
            //     {
            //         filter.Replace(filter[i],' ');
            //     }
            // }
            // message = brokenMsg[0] + filter;
            // Console.WriteLine("Right msg + " + message);
            Console.ReadKey();
        }


    }
}
