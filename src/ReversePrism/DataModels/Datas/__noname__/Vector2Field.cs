using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 IncStep                                  ModelPrimitiveType float float float Single
    // 064 IncStepMult                              ModelPrimitiveType float float float Single
    // 068 Decimals                                 ModelPrimitiveType int int int Int32
    public partial class Vector2Field : DataModel
    {
        public float                                    IncStep                                 { get; set; }
        public float                                    IncStepMult                             { get; set; }
        public int                                      Decimals                                { get; set; }

        public static Vector2Field? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector2Field() { Pointer= p0 };

            value.IncStep                                   = GetSingle(new IntPtr(p + 0x060)); // 0x60 IncStep                     ( ModelPrimitiveType float float float Single )
            value.IncStepMult                               = GetSingle(new IntPtr(p + 0x064)); // 0x64 IncStepMult                 ( ModelPrimitiveType float float float Single )
            value.Decimals                                  = GetInt32(new IntPtr(p + 0x068)); // 0x68 Decimals                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
