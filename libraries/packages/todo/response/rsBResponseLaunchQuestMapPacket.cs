﻿using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Packet type 0.
    /// </summary>
    public class PacketBResponseLaunchQuestMapPacket
    {

        public byte[] Response { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="request">The request.</param>
        public PacketBResponseLaunchQuestMapPacket(byte[] request)
        {

            Response = request;


        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (var Stream = new MemoryStream())
            {

                using (var Writer = new BinaryWriter(Stream))
                {

                    byte[] Package;

                    //Writer.Write(Content);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        /// <summary>
        /// Override ToString method.
        /// </summary>
        public sealed override string ToString()
        {

            return string.Format(
                "PacketBResponseLaunchQuestMapPacket\r\n" +
                "Response = {0}\r\n",
                Helper.PrintBytes(Response)
            );

        }

    }

}
