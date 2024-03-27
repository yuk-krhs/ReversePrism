using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActionType                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Rate                                     0001866656B0 ModelPrimitiveType float float float Single
    public partial class AiScoreRateSet
    {
        public int                                      ActionType                              { get; set; }
        public float                                    Rate                                    { get; set; }

        public static AiScoreRateSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiScoreRateSet();

            value.ActionType                                = GetInt32(new IntPtr(p + 0x010)); // 0270D5AAF098 0x10 ActionType                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rate                                      = GetSingle(new IntPtr(p + 0x014)); // 0270D5AAF0B8 0x14 Rate                        ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
