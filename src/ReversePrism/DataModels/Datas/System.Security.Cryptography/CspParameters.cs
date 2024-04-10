using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProviderType                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 ProviderName                             0001866722E0 ModelPrimitiveType string string string String
    // 020 KeyContainerName                         0001866722E0 ModelPrimitiveType string string string String
    // 028 KeyNumber                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C M_flags                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CspParameters : DataModel
    {
        public int                                      ProviderType                            { get; set; }
        public string                                   ProviderName                            { get; set; }
        public string                                   KeyContainerName                        { get; set; }
        public int                                      KeyNumber                               { get; set; }
        public int                                      M_flags                                 { get; set; }

        public static CspParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CspParameters() { Pointer= p0 };

            value.ProviderType                              = GetInt32(new IntPtr(p + 0x010)); // 0246669ACF40 0x10 ProviderType                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ProviderName                              = GetString(new IntPtr(p + 0x018)); // 0246669ACF60 0x18 ProviderName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.KeyContainerName                          = GetString(new IntPtr(p + 0x020)); // 0246669ACF80 0x20 KeyContainerName            ( 0001866722E0 ModelPrimitiveType string string string String )
            value.KeyNumber                                 = GetInt32(new IntPtr(p + 0x028)); // 0246669ACFA0 0x28 KeyNumber                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.M_flags                                   = GetInt32(new IntPtr(p + 0x02C)); // 0246669ACFC0 0x2C M_flags                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
