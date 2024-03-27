using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TabIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IdolListPermanentData
    {
        public int                                      TabIndex                                { get; set; }

        public static IdolListPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListPermanentData();

            value.TabIndex                                  = GetInt32(new IntPtr(p + 0x010)); // 027003A6A528 0x10 TabIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
