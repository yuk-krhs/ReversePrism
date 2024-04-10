using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstExchangeGroupId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstSelectionTicketProduct : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstExchangeGroupId                      { get; set; }
        public int                                      SortId                                  { get; set; }

        public static MstSelectionTicketProduct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSelectionTicketProduct() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02466AB08468 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstExchangeGroupId                        = GetInt32(new IntPtr(p + 0x014)); // 02466AB08488 0x14 MstExchangeGroupId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x018)); // 02466AB084A8 0x18 SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
