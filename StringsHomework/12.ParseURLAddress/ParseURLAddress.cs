using System;

class ParseURLAddress
{
    static void Main(string[] args)
    {
        string url = @"http://www.devbg.org/forum/index.php";
        string protocol;
        string server;
        string resource;

        int protocolIndex = url.IndexOf("://");
        protocol = url.Substring(0, protocolIndex);

        int serverIndexStart = protocolIndex + 3; // ://.Length = 3
        int serverIndexEnd = url.IndexOf("/", serverIndexStart);
        server = url.Substring(serverIndexStart,serverIndexEnd - serverIndexStart);

        
        resource = url.Substring(serverIndexEnd);

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}

