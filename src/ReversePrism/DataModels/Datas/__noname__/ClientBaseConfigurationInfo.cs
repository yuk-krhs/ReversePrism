using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Host                                     ModelPrimitiveType string string string String
    // 018 CallOptions                              ModelEnumType CallOptions CallOptions CallOptions Int32
    public partial class ClientBaseConfigurationInfo : DataModel
    {
        public string                                   Host                                    { get; set; }
        public CallOptions                              CallOptions                             { get; set; }

        public static ClientBaseConfigurationInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientBaseConfigurationInfo() { Pointer= p0 };

            value.Host                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Host                        ( ModelPrimitiveType string string string String )
            value.CallOptions                               = (CallOptions)GetInt32(new IntPtr(p + 0x018)); // 0x18 CallOptions                 ( ModelEnumType CallOptions CallOptions CallOptions Int32 )

            return value;
        }
    }
}
