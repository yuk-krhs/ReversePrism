using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TcpClient                                0001866271D0 ModelClassType TcpClient TcpClient TcpClient Pointer
    // 018 NetworkStream                            00018669CD10 ModelClassType NetworkStream NetworkStream NetworkStream Pointer
    public partial class TcpConnectionInfo : DataModel
    {
        public TcpClient?                               TcpClient                               { get; set; }
        public NetworkStream?                           NetworkStream                           { get; set; }

        public static TcpConnectionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TcpConnectionInfo() { Pointer= p0 };

            value.TcpClient                                 = GetObject<TcpClient>(new IntPtr(p + 0x010), ReversePrism.DataModels.TcpClient.FromPointer); // 02466B76CBE8 0x10 TcpClient                   ( 0001866271D0 ModelClassType TcpClient TcpClient TcpClient Pointer )
            value.NetworkStream                             = GetObject<NetworkStream>(new IntPtr(p + 0x018), ReversePrism.DataModels.NetworkStream.FromPointer); // 02466B76CC08 0x18 NetworkStream               ( 00018669CD10 ModelClassType NetworkStream NetworkStream NetworkStream Pointer )

            return value;
        }
    }
}
