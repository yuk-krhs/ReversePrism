using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Hdr                                      ModelPrimitiveType bool bool bool Bool
    // 061 ShowAlpha                                ModelPrimitiveType bool bool bool Bool
    // 062 ShowPicker                               ModelPrimitiveType bool bool bool Bool
    // 064 IncStep                                  ModelPrimitiveType float float float Single
    // 068 IncStepMult                              ModelPrimitiveType float float float Single
    // 06C Decimals                                 ModelPrimitiveType int int int Int32
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

            value.Hdr                                       = GetBool(new IntPtr(p + 0x060)); // 0x60 Hdr                         ( ModelPrimitiveType bool bool bool Bool )
            value.ShowAlpha                                 = GetBool(new IntPtr(p + 0x061)); // 0x61 ShowAlpha                   ( ModelPrimitiveType bool bool bool Bool )
            value.ShowPicker                                = GetBool(new IntPtr(p + 0x062)); // 0x62 ShowPicker                  ( ModelPrimitiveType bool bool bool Bool )
            value.IncStep                                   = GetSingle(new IntPtr(p + 0x064)); // 0x64 IncStep                     ( ModelPrimitiveType float float float Single )
            value.IncStepMult                               = GetSingle(new IntPtr(p + 0x068)); // 0x68 IncStepMult                 ( ModelPrimitiveType float float float Single )
            value.Decimals                                  = GetInt32(new IntPtr(p + 0x06C)); // 0x6C Decimals                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
