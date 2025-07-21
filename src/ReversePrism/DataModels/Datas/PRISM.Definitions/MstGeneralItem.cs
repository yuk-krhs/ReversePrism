using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductType                              ModelPrimitiveType int int int Int32
    // 014 Id                                       ModelPrimitiveType int int int Int32
    public partial class MstGeneralItem : DataModel
    {
        public int                                      ProductType                             { get; set; }
        public int                                      Id                                      { get; set; }

        public static MstGeneralItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstGeneralItem() { Pointer= p0 };

            value.ProductType                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 ProductType                 ( ModelPrimitiveType int int int Int32 )
            value.Id                                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 Id                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
