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
    public partial class TcpClient : DataModel
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
            var value   = new TcpClient() { Pointer= p0 };

            value.M_ClientSocket                            = GetObject<Socket>(new IntPtr(p + 0x010), ReversePrism.DataModels.Socket.FromPointer); // 024667A66B40 0x10 M_ClientSocket              ( 0001865214F0 ModelClassType Socket Socket Socket Pointer )
            value.M_Active                                  = GetBool(new IntPtr(p + 0x018)); // 024667A66B60 0x18 M_Active                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DataStream                              = GetObject<NetworkStream>(new IntPtr(p + 0x020), ReversePrism.DataModels.NetworkStream.FromPointer); // 024667A66B80 0x20 M_DataStream                ( 00018669CD10 ModelClassType NetworkStream NetworkStream NetworkStream Pointer )
            value.M_Family                                  = (AddressFamily)GetInt32(new IntPtr(p + 0x028)); // 024667A66BA0 0x28 M_Family                    ( 00018668D230 ModelEnumType AddressFamily AddressFamily AddressFamily Int32 )
            value.M_CleanedUp                               = GetBool(new IntPtr(p + 0x02C)); // 024667A66BC0 0x2C M_CleanedUp                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
