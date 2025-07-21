using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstProduceCardId                         ModelPrimitiveType int int int Int32
    // 014 MstProduceCardContentGroupTypeId         ModelPrimitiveType int int int Int32
    public partial class MstProduceCardContentGroup : DataModel
    {
        public int                                      MstProduceCardId                        { get; set; }
        public int                                      MstProduceCardContentGroupTypeId        { get; set; }

        public static MstProduceCardContentGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstProduceCardContentGroup() { Pointer= p0 };

            value.MstProduceCardId                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstProduceCardId            ( ModelPrimitiveType int int int Int32 )
            value.MstProduceCardContentGroupTypeId          = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstProduceCardContentGroupTypeId ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
