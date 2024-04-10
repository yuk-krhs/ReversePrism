using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetAssetVersionArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 OsNameFieldNumber                        int IL2CPP_TYPE_I4
    // 018 OsName                                   000186671910 ModelPrimitiveType string string string String
    // 000 UnityVersionFieldNumber                  int IL2CPP_TYPE_I4
    // 020 UnityVersion                             000186671910 ModelPrimitiveType string string string String
    // 000 EnvironmentFieldNumber                   int IL2CPP_TYPE_I4
    // 028 Environment                              000186671910 ModelPrimitiveType string string string String
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Token                                    000186671910 ModelPrimitiveType string string string String
    public partial class GetAssetVersionArgs : DataModel
    {
        public string                                   OsName                                  { get; set; }
        public string                                   UnityVersion                            { get; set; }
        public string                                   Environment                             { get; set; }
        public string                                   Token                                   { get; set; }

        public static GetAssetVersionArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetAssetVersionArgs() { Pointer= p0 };

            value.OsName                                    = GetString(new IntPtr(p + 0x018)); // 024660B0EB18 0x18 OsName                      ( 000186671910 ModelPrimitiveType string string string String )
            value.UnityVersion                              = GetString(new IntPtr(p + 0x020)); // 024660B0EB58 0x20 UnityVersion                ( 000186671910 ModelPrimitiveType string string string String )
            value.Environment                               = GetString(new IntPtr(p + 0x028)); // 024660B0EB98 0x28 Environment                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Token                                     = GetString(new IntPtr(p + 0x030)); // 024660B0EBD8 0x30 Token                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
