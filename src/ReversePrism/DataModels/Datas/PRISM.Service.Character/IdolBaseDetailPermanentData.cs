using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TabIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IdolBaseDetailPermanentData
    {
        public int                                      TabIndex                                { get; set; }

        public static IdolBaseDetailPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailPermanentData();

            value.TabIndex                                  = GetInt32(new IntPtr(p + 0x010)); // 027003A6EE88 0x10 TabIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
