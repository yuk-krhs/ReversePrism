using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ItemId                                   ModelPrimitiveType string string string String
    // 018 ItemName                                 ModelPrimitiveType string string string String
    // 020 UnitPrice                                ModelPrimitiveType int int int Int32
    // 024 Quantity                                 ModelPrimitiveType int int int Int32
    // 028 ImageUrl                                 ModelPrimitiveType string string string String
    // 030 Description                              ModelPrimitiveType string string string String
    public partial class PaymentItem : DataModel
    {
        public string                                   ItemId                                  { get; set; }
        public string                                   ItemName                                { get; set; }
        public int                                      UnitPrice                               { get; set; }
        public int                                      Quantity                                { get; set; }
        public string                                   ImageUrl                                { get; set; }
        public string                                   Description                             { get; set; }

        public static PaymentItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PaymentItem() { Pointer= p0 };

            value.ItemId                                    = GetString(new IntPtr(p + 0x010)); // 0x10 ItemId                      ( ModelPrimitiveType string string string String )
            value.ItemName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 ItemName                    ( ModelPrimitiveType string string string String )
            value.UnitPrice                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 UnitPrice                   ( ModelPrimitiveType int int int Int32 )
            value.Quantity                                  = GetInt32(new IntPtr(p + 0x024)); // 0x24 Quantity                    ( ModelPrimitiveType int int int Int32 )
            value.ImageUrl                                  = GetString(new IntPtr(p + 0x028)); // 0x28 ImageUrl                    ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x030)); // 0x30 Description                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
