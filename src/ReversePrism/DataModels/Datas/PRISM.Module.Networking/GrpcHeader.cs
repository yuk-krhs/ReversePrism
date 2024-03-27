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
    public partial class GrpcHeader
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
            var value   = new GrpcHeader();

            value.OsName                                    = GetString(new IntPtr(p + 0x010)); // 027004B3A028 0x10 OsName                      ( 000186674040 ModelPrimitiveType string string string String )
            value.ApplicationVersion                        = GetString(new IntPtr(p + 0x018)); // 027004B3A048 0x18 ApplicationVersion          ( 000186674040 ModelPrimitiveType string string string String )
            value.VersionHash                               = GetString(new IntPtr(p + 0x020)); // 027004B3A068 0x20 VersionHash                 ( 000186674040 ModelPrimitiveType string string string String )
            value.PlatformUserId                            = GetString(new IntPtr(p + 0x028)); // 027004B3A088 0x28 PlatformUserId              ( 000186674040 ModelPrimitiveType string string string String )
            value.ResourceVersion                           = GetString(new IntPtr(p + 0x030)); // 027004B3A0A8 0x30 ResourceVersion             ( 000186674040 ModelPrimitiveType string string string String )
            value.ResourceTarget                            = GetString(new IntPtr(p + 0x038)); // 027004B3A0C8 0x38 ResourceTarget              ( 000186674040 ModelPrimitiveType string string string String )
            value.CloudTraceContext                         = GetString(new IntPtr(p + 0x040)); // 027004B3A0E8 0x40 CloudTraceContext           ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
