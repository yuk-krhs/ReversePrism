using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 defaultAndroidDeviceReadBitrate          int IL2CPP_TYPE_I4
    // 010 NumberOfLoaders                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 NumberOfBinders                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 NumberOfInstallers                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C InstallBufferSize                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 MaxPath                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 UserAgentString                          0001866722E0 ModelPrimitiveType string string string String
    // 030 MinimizeFileDescriptorUsage              000186595960 ModelPrimitiveType bool bool bool Bool
    // 031 EnableCrcCheck                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 034 AndroidDeviceReadBitrate                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class CriFsConfig
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
            var value   = new CriFsConfig();

            value.NumberOfLoaders                           = GetInt32(new IntPtr(p + 0x010)); // 0270D11707C0 0x10 NumberOfLoaders             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumberOfBinders                           = GetInt32(new IntPtr(p + 0x014)); // 0270D11707E0 0x14 NumberOfBinders             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumberOfInstallers                        = GetInt32(new IntPtr(p + 0x018)); // 0270D1170800 0x18 NumberOfInstallers          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.InstallBufferSize                         = GetInt32(new IntPtr(p + 0x01C)); // 0270D1170820 0x1C InstallBufferSize           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxPath                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D1170840 0x20 MaxPath                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UserAgentString                           = GetString(new IntPtr(p + 0x028)); // 0270D1170860 0x28 UserAgentString             ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MinimizeFileDescriptorUsage               = GetBool(new IntPtr(p + 0x030)); // 0270D1170880 0x30 MinimizeFileDescriptorUsage ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.EnableCrcCheck                            = GetBool(new IntPtr(p + 0x031)); // 0270D11708A0 0x31 EnableCrcCheck              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AndroidDeviceReadBitrate                  = GetInt32(new IntPtr(p + 0x034)); // 0270D11708C0 0x34 AndroidDeviceReadBitrate    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
