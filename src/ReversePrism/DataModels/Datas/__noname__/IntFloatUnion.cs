using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IntValue                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 010 FloatValue                               000186666050 ModelPrimitiveType float float float Single
    public partial class IntFloatUnion
    {
        public int                                      IntValue                                { get; set; }
        public float                                    FloatValue                              { get; set; }

        public static IntFloatUnion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntFloatUnion();

            value.IntValue                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D7E174D8 0x10 IntValue                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FloatValue                                = GetSingle(new IntPtr(p + 0x010)); // 0270D7E174F8 0x10 FloatValue                  ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
