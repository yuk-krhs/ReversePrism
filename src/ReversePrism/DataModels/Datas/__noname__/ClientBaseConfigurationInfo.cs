using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Host                                     0001866731A0 ModelPrimitiveType string string string String
    // 018 CallOptions                              00018652BCF0 ModelEnumType CallOptions CallOptions CallOptions Int32
    public partial class ClientBaseConfigurationInfo
    {
        public string                                   Host                                    { get; set; }
        public CallOptions                              CallOptions                             { get; set; }

        public static ClientBaseConfigurationInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientBaseConfigurationInfo();

            value.Host                                      = GetString(new IntPtr(p + 0x010)); // 0270DBB3A308 0x10 Host                        ( 0001866731A0 ModelPrimitiveType string string string String )
            value.CallOptions                               = (CallOptions)GetInt32(new IntPtr(p + 0x018)); // 0270DBB3A328 0x18 CallOptions                 ( 00018652BCF0 ModelEnumType CallOptions CallOptions CallOptions Int32 )

            return value;
        }
    }
}
