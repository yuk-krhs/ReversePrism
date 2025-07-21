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
    // 010 OsName                                   ModelPrimitiveType string string string String
    // 018 ApplicationVersion                       ModelPrimitiveType string string string String
    // 020 ApplicationVersionForCatalog             ModelPrimitiveType string string string String
    // 028 VersionHash                              ModelPrimitiveType string string string String
    // 030 PlatformUserId                           ModelPrimitiveType string string string String
    // 038 ResourceVersion                          ModelPrimitiveType string string string String
    // 040 ResourceTarget                           ModelPrimitiveType string string string String
    // 048 CloudTraceContext                        ModelPrimitiveType string string string String
    public partial class GrpcHeader : DataModel
    {
        public string                                   OsName                                  { get; set; }
        public string                                   ApplicationVersion                      { get; set; }
        public string                                   ApplicationVersionForCatalog            { get; set; }
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

            value.OsName                                    = GetString(new IntPtr(p + 0x010)); // 0x10 OsName                      ( ModelPrimitiveType string string string String )
            value.ApplicationVersion                        = GetString(new IntPtr(p + 0x018)); // 0x18 ApplicationVersion          ( ModelPrimitiveType string string string String )
            value.ApplicationVersionForCatalog              = GetString(new IntPtr(p + 0x020)); // 0x20 ApplicationVersionForCatalog ( ModelPrimitiveType string string string String )
            value.VersionHash                               = GetString(new IntPtr(p + 0x028)); // 0x28 VersionHash                 ( ModelPrimitiveType string string string String )
            value.PlatformUserId                            = GetString(new IntPtr(p + 0x030)); // 0x30 PlatformUserId              ( ModelPrimitiveType string string string String )
            value.ResourceVersion                           = GetString(new IntPtr(p + 0x038)); // 0x38 ResourceVersion             ( ModelPrimitiveType string string string String )
            value.ResourceTarget                            = GetString(new IntPtr(p + 0x040)); // 0x40 ResourceTarget              ( ModelPrimitiveType string string string String )
            value.CloudTraceContext                         = GetString(new IntPtr(p + 0x048)); // 0x48 CloudTraceContext           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
