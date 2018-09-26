using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using FileWorker = FileService.FileWorker;

namespace Second.Server
{
    public class ThreadClass
    {
        private NetworkStream ns = null;
        private ASCIIEncoding ae = null;

        private FileWorker fw;

        public Thread Start(NetworkStream ns, string fileName)
        {
            this.ns = ns;
            fw = new FileWorker(fileName);
            ae = new ASCIIEncoding();
            var thread = new Thread(ThreadOperations);
            thread.Start();
            return thread;
        }

        private void ThreadOperations()
        {
            var received = new byte[256];
            ns.Read(received, 0, received.Length);

            string receivedString = ae.GetString(received);
            receivedString = receivedString.Replace("\0", string.Empty);
            int index = receivedString.IndexOf("|", 0, StringComparison.Ordinal);
            string cmd = receivedString.Substring(0, index);

            string information = null;
            if (!cmd.Equals("print"))
            {
                information = receivedString.Substring(index + 1, receivedString.Length - index - 1);
            }

            if (string.Compare(cmd, "print", StringComparison.Ordinal) == 0)
            {
                var sent = new byte[256];

                sent = ae.GetBytes(fw.GetAll());

                ns.Write(sent, 0, sent.Length);
            }

            if (string.Compare(cmd, "add", StringComparison.Ordinal) == 0)
            {
                var sent = new byte[256];
                var tempArray = information.Split(' ');
                fw.Add(tempArray[0], tempArray[1], tempArray[2]);
                sent = ae.GetBytes("Ok");

                ns.Write(sent, 0, sent.Length);
            }

            if (string.Compare(cmd, "del", StringComparison.Ordinal) == 0)
            {
                var sent = new byte[256];
                fw.Delete(information);
                sent = ae.GetBytes("Ok");

                ns.Write(sent, 0, sent.Length);
            }

            if (string.Compare(cmd, "up", StringComparison.Ordinal) == 0)
            {
                var sent = new byte[256];
                var tempArray = information.Split(' ');
                fw.Update(tempArray[0], tempArray[1], tempArray[2], tempArray[3]);
                sent = ae.GetBytes("Ok");

                ns.Write(sent, 0, sent.Length);
            }

            if (string.Compare(cmd, "search", StringComparison.Ordinal) == 0)
            {
                var sent = new byte[256];
                sent = ae.GetBytes(fw.Search(information));

                ns.Write(sent, 0, sent.Length);
            }
        }
    }
}
