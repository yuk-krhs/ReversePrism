using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartCharIdx                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Height                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 TopY                                     000186666050 ModelPrimitiveType float float float Single
    // 01C Leading                                  000186666050 ModelPrimitiveType float float float Single
    public partial class UILineInfo
    {
        public int                                      StartCharIdx                            { get; set; }
        public int                                      Height                                  { get; set; }
        public float                                    TopY                                    { get; set; }
        public float                                    Leading                                 { get; set; }

        public static UILineInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UILineInfo();

            value.StartCharIdx                              = GetInt32(new IntPtr(p + 0x010)); // 027002181440 0x10 StartCharIdx                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x014)); // 027002181460 0x14 Height                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TopY                                      = GetSingle(new IntPtr(p + 0x018)); // 027002181480 0x18 TopY                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Leading                                   = GetSingle(new IntPtr(p + 0x01C)); // 0270021814A0 0x1C Leading                     ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
