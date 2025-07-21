using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 defaultAndroidDeviceReadBitrate          int IL2CPP_TYPE_I4
    // 010 NumberOfLoaders                          ModelPrimitiveType int int int Int32
    // 014 NumberOfBinders                          ModelPrimitiveType int int int Int32
    // 018 NumberOfInstallers                       ModelPrimitiveType int int int Int32
    // 01C InstallBufferSize                        ModelPrimitiveType int int int Int32
    // 020 MaxPath                                  ModelPrimitiveType int int int Int32
    // 028 UserAgentString                          ModelPrimitiveType string string string String
    // 030 MinimizeFileDescriptorUsage              ModelPrimitiveType bool bool bool Bool
    // 031 EnableCrcCheck                           ModelPrimitiveType bool bool bool Bool
    // 034 AndroidDeviceReadBitrate                 ModelPrimitiveType int int int Int32
    public partial class CriFsConfig : DataModel
    {
        public int                                      NumberOfLoaders                         { get; set; }
        public int                                      NumberOfBinders                         { get; set; }
        public int                                      NumberOfInstallers                      { get; set; }
        public int                                      InstallBufferSize                       { get; set; }
        public int                                      MaxPath                                 { get; set; }
        public string                                   UserAgentString                         { get; set; }
        public bool                                     MinimizeFileDescriptorUsage             { get; set; }
        public bool                                     EnableCrcCheck                          { get; set; }
        public int                                      AndroidDeviceReadBitrate                { get; set; }

        public static CriFsConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsConfig() { Pointer= p0 };

            value.NumberOfLoaders                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 NumberOfLoaders             ( ModelPrimitiveType int int int Int32 )
            value.NumberOfBinders                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 NumberOfBinders             ( ModelPrimitiveType int int int Int32 )
            value.NumberOfInstallers                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 NumberOfInstallers          ( ModelPrimitiveType int int int Int32 )
            value.InstallBufferSize                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C InstallBufferSize           ( ModelPrimitiveType int int int Int32 )
            value.MaxPath                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 MaxPath                     ( ModelPrimitiveType int int int Int32 )
            value.UserAgentString                           = GetString(new IntPtr(p + 0x028)); // 0x28 UserAgentString             ( ModelPrimitiveType string string string String )
            value.MinimizeFileDescriptorUsage               = GetBool(new IntPtr(p + 0x030)); // 0x30 MinimizeFileDescriptorUsage ( ModelPrimitiveType bool bool bool Bool )
            value.EnableCrcCheck                            = GetBool(new IntPtr(p + 0x031)); // 0x31 EnableCrcCheck              ( ModelPrimitiveType bool bool bool Bool )
            value.AndroidDeviceReadBitrate                  = GetInt32(new IntPtr(p + 0x034)); // 0x34 AndroidDeviceReadBitrate    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
