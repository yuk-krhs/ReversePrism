using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IntValue                                 ModelPrimitiveType int int int Int32
    // 010 FloatValue                               ModelPrimitiveType float float float Single
    public partial class IntFloatUnion : DataModel
    {
        public int                                      IntValue                                { get; set; }
        public float                                    FloatValue                              { get; set; }

        public static IntFloatUnion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntFloatUnion() { Pointer= p0 };

            value.IntValue                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 IntValue                    ( ModelPrimitiveType int int int Int32 )
            value.FloatValue                                = GetSingle(new IntPtr(p + 0x010)); // 0x10 FloatValue                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
