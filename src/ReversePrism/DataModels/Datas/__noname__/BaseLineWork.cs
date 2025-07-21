using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vindex                                   ModelPrimitiveType int int int Int32
    // 014 Dist                                     ModelPrimitiveType float float float Single
    public partial class BaseLineWork : DataModel
    {
        public int                                      Vindex                                  { get; set; }
        public float                                    Dist                                    { get; set; }

        public static BaseLineWork? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseLineWork() { Pointer= p0 };

            value.Vindex                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Vindex                      ( ModelPrimitiveType int int int Int32 )
            value.Dist                                      = GetSingle(new IntPtr(p + 0x014)); // 0x14 Dist                        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
