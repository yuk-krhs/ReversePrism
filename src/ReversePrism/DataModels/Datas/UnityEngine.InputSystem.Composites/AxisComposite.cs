using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Negative                                 ModelPrimitiveType int int int Int32
    // 014 Positive                                 ModelPrimitiveType int int int Int32
    // 018 MinValue                                 ModelPrimitiveType float float float Single
    // 01C MaxValue                                 ModelPrimitiveType float float float Single
    // 020 WhichSideWins                            ModelEnumType WhichSideWins WhichSideWins WhichSideWins Int32
    public partial class AxisComposite : DataModel
    {
        public int                                      Negative                                { get; set; }
        public int                                      Positive                                { get; set; }
        public float                                    MinValue                                { get; set; }
        public float                                    MaxValue                                { get; set; }
        public WhichSideWins                            WhichSideWins                           { get; set; }

        public static AxisComposite? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AxisComposite() { Pointer= p0 };

            value.Negative                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 Negative                    ( ModelPrimitiveType int int int Int32 )
            value.Positive                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 Positive                    ( ModelPrimitiveType int int int Int32 )
            value.MinValue                                  = GetSingle(new IntPtr(p + 0x018)); // 0x18 MinValue                    ( ModelPrimitiveType float float float Single )
            value.MaxValue                                  = GetSingle(new IntPtr(p + 0x01C)); // 0x1C MaxValue                    ( ModelPrimitiveType float float float Single )
            value.WhichSideWins                             = (WhichSideWins)GetInt32(new IntPtr(p + 0x020)); // 0x20 WhichSideWins               ( ModelEnumType WhichSideWins WhichSideWins WhichSideWins Int32 )

            return value;
        }
    }
}
