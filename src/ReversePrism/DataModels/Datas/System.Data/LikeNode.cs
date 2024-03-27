using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Kind                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Pattern                                  000186671910 ModelPrimitiveType string string string String
    public partial class LikeNode
    {
        public int                                      Kind                                    { get; set; }
        public string                                   Pattern                                 { get; set; }

        public static LikeNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LikeNode();

            value.Kind                                      = GetInt32(new IntPtr(p + 0x030)); // 0270D89291B8 0x30 Kind                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Pattern                                   = GetString(new IntPtr(p + 0x038)); // 0270D89291D8 0x38 Pattern                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
