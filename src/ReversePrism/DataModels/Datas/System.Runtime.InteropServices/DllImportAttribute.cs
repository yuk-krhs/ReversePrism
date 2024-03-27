using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Val                                      000186671BA0 ModelPrimitiveType string string string String
    // 018 EntryPoint                               0001866722E0 ModelPrimitiveType string string string String
    // 020 CharSet                                  000186595AB0 ModelEnumType CharSet CharSet CharSet Int32
    // 024 SetLastError                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 025 ExactSpelling                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 026 PreserveSig                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 CallingConvention                        000186533DE0 ModelEnumType CallingConvention CallingConvention CallingConvention Int32
    // 02C BestFitMapping                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 02D ThrowOnUnmappableChar                    000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class DllImportAttribute
    {
        public string                                   Val                                     { get; set; }
        public string                                   EntryPoint                              { get; set; }
        public CharSet                                  CharSet                                 { get; set; }
        public bool                                     SetLastError                            { get; set; }
        public bool                                     ExactSpelling                           { get; set; }
        public bool                                     PreserveSig                             { get; set; }
        public CallingConvention                        CallingConvention                       { get; set; }
        public bool                                     BestFitMapping                          { get; set; }
        public bool                                     ThrowOnUnmappableChar                   { get; set; }

        public static DllImportAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DllImportAttribute();

            value.Val                                       = GetString(new IntPtr(p + 0x010)); // 0270D6C83370 0x10 Val                         ( 000186671BA0 ModelPrimitiveType string string string String )
            value.EntryPoint                                = GetString(new IntPtr(p + 0x018)); // 0270D6C83390 0x18 EntryPoint                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CharSet                                   = (CharSet)GetInt32(new IntPtr(p + 0x020)); // 0270D6C833B0 0x20 CharSet                     ( 000186595AB0 ModelEnumType CharSet CharSet CharSet Int32 )
            value.SetLastError                              = GetBool(new IntPtr(p + 0x024)); // 0270D6C833D0 0x24 SetLastError                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ExactSpelling                             = GetBool(new IntPtr(p + 0x025)); // 0270D6C833F0 0x25 ExactSpelling               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PreserveSig                               = GetBool(new IntPtr(p + 0x026)); // 0270D6C83410 0x26 PreserveSig                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CallingConvention                         = (CallingConvention)GetInt32(new IntPtr(p + 0x028)); // 0270D6C83430 0x28 CallingConvention           ( 000186533DE0 ModelEnumType CallingConvention CallingConvention CallingConvention Int32 )
            value.BestFitMapping                            = GetBool(new IntPtr(p + 0x02C)); // 0270D6C83450 0x2C BestFitMapping              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ThrowOnUnmappableChar                     = GetBool(new IntPtr(p + 0x02D)); // 0270D6C83470 0x2D ThrowOnUnmappableChar       ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
