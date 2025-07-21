using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelPrimitiveType int int int Int32
    // 014 Rate                                     ModelPrimitiveType float float float Single
    public partial class ExternalIKData : DataModel
    {
        public int                                      Target                                  { get; set; }
        public float                                    Rate                                    { get; set; }

        public static ExternalIKData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExternalIKData() { Pointer= p0 };

            value.Target                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Target                      ( ModelPrimitiveType int int int Int32 )
            value.Rate                                      = GetSingle(new IntPtr(p + 0x014)); // 0x14 Rate                        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
