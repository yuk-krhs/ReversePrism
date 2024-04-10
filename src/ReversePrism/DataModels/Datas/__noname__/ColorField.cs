using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Hdr                                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 061 ShowAlpha                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 062 ShowPicker                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 064 IncStep                                  000186666050 ModelPrimitiveType float float float Single
    // 068 IncStepMult                              000186666050 ModelPrimitiveType float float float Single
    // 06C Decimals                                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ColorField : DataModel
    {
        public bool                                     Hdr                                     { get; set; }
        public bool                                     ShowAlpha                               { get; set; }
        public bool                                     ShowPicker                              { get; set; }
        public float                                    IncStep                                 { get; set; }
        public float                                    IncStepMult                             { get; set; }
        public int                                      Decimals                                { get; set; }

        public static ColorField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorField() { Pointer= p0 };

            value.Hdr                                       = GetBool(new IntPtr(p + 0x060)); // 0246691DF5C8 0x60 Hdr                         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShowAlpha                                 = GetBool(new IntPtr(p + 0x061)); // 0246691DF5E8 0x61 ShowAlpha                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShowPicker                                = GetBool(new IntPtr(p + 0x062)); // 0246691DF608 0x62 ShowPicker                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IncStep                                   = GetSingle(new IntPtr(p + 0x064)); // 0246691DF628 0x64 IncStep                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.IncStepMult                               = GetSingle(new IntPtr(p + 0x068)); // 0246691DF648 0x68 IncStepMult                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Decimals                                  = GetInt32(new IntPtr(p + 0x06C)); // 0246691DF668 0x6C Decimals                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
