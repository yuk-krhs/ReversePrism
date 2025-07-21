using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PickUnused                               int IL2CPP_TYPE_I4
    // 010 Host                                     ModelPrimitiveType string string string String
    // 018 Port                                     ModelPrimitiveType int int int Int32
    // 020 Credentials                              ModelClassType ServerCredentials ServerCredentials ServerCredentials Pointer
    // 028 BoundPort                                ModelPrimitiveType int int int Int32
    public partial class ServerPort : DataModel
    {
        public string                                   Host                                    { get; set; }
        public int                                      Port                                    { get; set; }
        public ServerCredentials?                       Credentials                             { get; set; }
        public int                                      BoundPort                               { get; set; }

        public static ServerPort? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerPort() { Pointer= p0 };

            value.Host                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Host                        ( ModelPrimitiveType string string string String )
            value.Port                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Port                        ( ModelPrimitiveType int int int Int32 )
            value.Credentials                               = GetObject<ServerCredentials>(new IntPtr(p + 0x020), ReversePrism.DataModels.ServerCredentials.FromPointer); // 0x20 Credentials                 ( ModelClassType ServerCredentials ServerCredentials ServerCredentials Pointer )
            value.BoundPort                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 BoundPort                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
