using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Client                                   ModelClassType TcpClient TcpClient TcpClient Pointer
    // 030 NetworkStream                            ModelClassType NetworkStream NetworkStream NetworkStream Pointer
    public partial class NetworkStreamWrapper : DataModel
    {
        public TcpClient?                               Client                                  { get; set; }
        public NetworkStream?                           NetworkStream                           { get; set; }

        public static NetworkStreamWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NetworkStreamWrapper() { Pointer= p0 };

            value.Client                                    = GetObject<TcpClient>(new IntPtr(p + 0x028), ReversePrism.DataModels.TcpClient.FromPointer); // 0x28 Client                      ( ModelClassType TcpClient TcpClient TcpClient Pointer )
            value.NetworkStream                             = GetObject<NetworkStream>(new IntPtr(p + 0x030), ReversePrism.DataModels.NetworkStream.FromPointer); // 0x30 NetworkStream               ( ModelClassType NetworkStream NetworkStream NetworkStream Pointer )

            return value;
        }
    }
}
