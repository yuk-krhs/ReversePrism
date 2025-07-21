using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProviderType                             ModelPrimitiveType int int int Int32
    // 018 ProviderName                             ModelPrimitiveType string string string String
    // 020 KeyContainerName                         ModelPrimitiveType string string string String
    // 028 KeyNumber                                ModelPrimitiveType int int int Int32
    // 02C M_flags                                  ModelPrimitiveType int int int Int32
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

            value.ProviderType                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 ProviderType                ( ModelPrimitiveType int int int Int32 )
            value.ProviderName                              = GetString(new IntPtr(p + 0x018)); // 0x18 ProviderName                ( ModelPrimitiveType string string string String )
            value.KeyContainerName                          = GetString(new IntPtr(p + 0x020)); // 0x20 KeyContainerName            ( ModelPrimitiveType string string string String )
            value.KeyNumber                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 KeyNumber                   ( ModelPrimitiveType int int int Int32 )
            value.M_flags                                   = GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_flags                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
