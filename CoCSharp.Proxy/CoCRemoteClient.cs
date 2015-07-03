﻿using CoCSharp.Logic;
using CoCSharp.Networking;
using System.Net.Sockets;

namespace CoCSharp.Proxy
{
    public class CoCRemoteClient
    {
        public CoCRemoteClient(Socket connection)
        {
            this.Connection = connection;
            this.NetworkManager = new NetworkManager(connection);
        }

        public string Username { get; set; }
        public string UserToken { get; set; }
        public string FingerprintHash { get; set; }
        public long UserID { get; set; }
        public int Seed { get; set; }
        public bool LoggedIn { get; set; }
        public Village Home { get; set; }
        public Socket Connection { get; set; }
        public NetworkManager NetworkManager { get; set; }
    }
}
