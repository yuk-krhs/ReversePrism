using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ClientSocket                           0001865214F0 ModelClassType Socket Socket Socket Pointer
    // 018 M_Active                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 M_DataStream                             00018669CD10 ModelClassType NetworkStream NetworkStream NetworkStream Pointer
    // 028 M_Family                                 00018668D230 ModelEnumType AddressFamily AddressFamily AddressFamily Int32
    // 02C M_CleanedUp                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TcpClient
    {
        public Socket?                                  M_ClientSocket                          { get; set; }
        public bool                                     M_Active                                { get; set; }
        public NetworkStream?                           M_DataStream                            { get; set; }
        public AddressFamily                            M_Family                                { get; set; }
        public bool                                     M_CleanedUp                             { get; set; }

        public static TcpClient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TcpClient();

            value.M_ClientSocket                            = GetObject<Socket>(new IntPtr(p + 0x010), ReversePrism.DataModels.Socket.FromPointer); // 0270D7A0EB40 0x10 M_ClientSocket              ( 0001865214F0 ModelClassType Socket Socket Socket Pointer )
            value.M_Active                                  = GetBool(new IntPtr(p + 0x018)); // 0270D7A0EB60 0x18 M_Active                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DataStream                              = GetObject<NetworkStream>(new IntPtr(p + 0x020), ReversePrism.DataModels.NetworkStream.FromPointer); // 0270D7A0EB80 0x20 M_DataStream                ( 00018669CD10 ModelClassType NetworkStream NetworkStream NetworkStream Pointer )
            value.M_Family                                  = (AddressFamily)GetInt32(new IntPtr(p + 0x028)); // 0270D7A0EBA0 0x28 M_Family                    ( 00018668D230 ModelEnumType AddressFamily AddressFamily AddressFamily Int32 )
            value.M_CleanedUp                               = GetBool(new IntPtr(p + 0x02C)); // 0270D7A0EBC0 0x2C M_CleanedUp                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
