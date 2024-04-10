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
    public partial class DllImportAttribute : DataModel
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
            var value   = new DllImportAttribute() { Pointer= p0 };

            value.Val                                       = GetString(new IntPtr(p + 0x010)); // 024666CF3370 0x10 Val                         ( 000186671BA0 ModelPrimitiveType string string string String )
            value.EntryPoint                                = GetString(new IntPtr(p + 0x018)); // 024666CF3390 0x18 EntryPoint                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CharSet                                   = (CharSet)GetInt32(new IntPtr(p + 0x020)); // 024666CF33B0 0x20 CharSet                     ( 000186595AB0 ModelEnumType CharSet CharSet CharSet Int32 )
            value.SetLastError                              = GetBool(new IntPtr(p + 0x024)); // 024666CF33D0 0x24 SetLastError                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ExactSpelling                             = GetBool(new IntPtr(p + 0x025)); // 024666CF33F0 0x25 ExactSpelling               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PreserveSig                               = GetBool(new IntPtr(p + 0x026)); // 024666CF3410 0x26 PreserveSig                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CallingConvention                         = (CallingConvention)GetInt32(new IntPtr(p + 0x028)); // 024666CF3430 0x28 CallingConvention           ( 000186533DE0 ModelEnumType CallingConvention CallingConvention CallingConvention Int32 )
            value.BestFitMapping                            = GetBool(new IntPtr(p + 0x02C)); // 024666CF3450 0x2C BestFitMapping              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ThrowOnUnmappableChar                     = GetBool(new IntPtr(p + 0x02D)); // 024666CF3470 0x2D ThrowOnUnmappableChar       ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
