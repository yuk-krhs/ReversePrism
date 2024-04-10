using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 min                                      Func`1<float> IL2CPP_TYPE_GENERICINST
    // 068 max                                      Func`1<float> IL2CPP_TYPE_GENERICINST
    // 070 IncStep                                  000186666050 ModelPrimitiveType float float float Single
    // 074 IncStepMult                              000186666050 ModelPrimitiveType float float float Single
    // 078 Decimals                                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class FloatField : DataModel
    {
        public float                                    IncStep                                 { get; set; }
        public float                                    IncStepMult                             { get; set; }
        public int                                      Decimals                                { get; set; }

        public static FloatField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FloatField() { Pointer= p0 };

            value.IncStep                                   = GetSingle(new IntPtr(p + 0x070)); // 0246691DE460 0x70 IncStep                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.IncStepMult                               = GetSingle(new IntPtr(p + 0x074)); // 0246691DE480 0x74 IncStepMult                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Decimals                                  = GetInt32(new IntPtr(p + 0x078)); // 0246691DE4A0 0x78 Decimals                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
