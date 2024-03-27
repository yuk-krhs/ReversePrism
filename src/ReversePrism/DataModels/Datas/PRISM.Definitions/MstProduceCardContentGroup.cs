using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstProduceCardId                         0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstProduceCardContentGroupTypeId         0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstProduceCardContentGroup
    {
        public int                                      MstProduceCardId                        { get; set; }
        public int                                      MstProduceCardContentGroupTypeId        { get; set; }

        public static MstProduceCardContentGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstProduceCardContentGroup();

            value.MstProduceCardId                          = GetInt32(new IntPtr(p + 0x010)); // 02700459D950 0x10 MstProduceCardId            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstProduceCardContentGroupTypeId          = GetInt32(new IntPtr(p + 0x014)); // 02700459D970 0x14 MstProduceCardContentGroupTypeId ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
