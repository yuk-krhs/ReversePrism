using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Authorization                            string IL2CPP_TYPE_STRING
    // 008 ApplicationPlatform                      string IL2CPP_TYPE_STRING
    // 010 OsName                                   000186674040 ModelPrimitiveType string string string String
    // 018 ApplicationVersion                       000186674040 ModelPrimitiveType string string string String
    // 020 VersionHash                              000186674040 ModelPrimitiveType string string string String
    // 028 PlatformUserId                           000186674040 ModelPrimitiveType string string string String
    // 030 ResourceVersion                          000186674040 ModelPrimitiveType string string string String
    // 038 ResourceTarget                           000186674040 ModelPrimitiveType string string string String
    // 040 CloudTraceContext                        000186674040 ModelPrimitiveType string string string String
    public partial class GrpcHeader : DataModel
    {
        public string                                   OsName                                  { get; set; }
        public string                                   ApplicationVersion                      { get; set; }
        public string                                   VersionHash                             { get; set; }
        public string                                   PlatformUserId                          { get; set; }
        public string                                   ResourceVersion                         { get; set; }
        public string                                   ResourceTarget                          { get; set; }
        public string                                   CloudTraceContext                       { get; set; }

        public static GrpcHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GrpcHeader() { Pointer= p0 };

            value.OsName                                    = GetString(new IntPtr(p + 0x010)); // 0245A4B92AD8 0x10 OsName                      ( 000186674040 ModelPrimitiveType string string string String )
            value.ApplicationVersion                        = GetString(new IntPtr(p + 0x018)); // 0245A4B92AF8 0x18 ApplicationVersion          ( 000186674040 ModelPrimitiveType string string string String )
            value.VersionHash                               = GetString(new IntPtr(p + 0x020)); // 0245A4B92B18 0x20 VersionHash                 ( 000186674040 ModelPrimitiveType string string string String )
            value.PlatformUserId                            = GetString(new IntPtr(p + 0x028)); // 0245A4B92B38 0x28 PlatformUserId              ( 000186674040 ModelPrimitiveType string string string String )
            value.ResourceVersion                           = GetString(new IntPtr(p + 0x030)); // 0245A4B92B58 0x30 ResourceVersion             ( 000186674040 ModelPrimitiveType string string string String )
            value.ResourceTarget                            = GetString(new IntPtr(p + 0x038)); // 0245A4B92B78 0x38 ResourceTarget              ( 000186674040 ModelPrimitiveType string string string String )
            value.CloudTraceContext                         = GetString(new IntPtr(p + 0x040)); // 0245A4B92B98 0x40 CloudTraceContext           ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
