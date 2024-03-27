using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductType                              0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstGeneralItem
    {
        public int                                      ProductType                             { get; set; }
        public int                                      Id                                      { get; set; }

        public static MstGeneralItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstGeneralItem();

            value.ProductType                               = GetInt32(new IntPtr(p + 0x010)); // 02700459E718 0x10 ProductType                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Id                                        = GetInt32(new IntPtr(p + 0x014)); // 02700459E738 0x14 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
