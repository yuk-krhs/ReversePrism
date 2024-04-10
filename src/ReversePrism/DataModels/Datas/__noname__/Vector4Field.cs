using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 IncStep                                  000186666050 ModelPrimitiveType float float float Single
    // 064 IncStepMult                              000186666050 ModelPrimitiveType float float float Single
    // 068 Decimals                                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Vector4Field : DataModel
    {
        public float                                    IncStep                                 { get; set; }
        public float                                    IncStepMult                             { get; set; }
        public int                                      Decimals                                { get; set; }

        public static Vector4Field? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector4Field() { Pointer= p0 };

            value.IncStep                                   = GetSingle(new IntPtr(p + 0x060)); // 0246691DFB10 0x60 IncStep                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.IncStepMult                               = GetSingle(new IntPtr(p + 0x064)); // 0246691DFB30 0x64 IncStepMult                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Decimals                                  = GetInt32(new IntPtr(p + 0x068)); // 0246691DFB50 0x68 Decimals                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
