using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ItemId                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 ItemName                                 0001866722E0 ModelPrimitiveType string string string String
    // 020 UnitPrice                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 Quantity                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 ImageUrl                                 0001866722E0 ModelPrimitiveType string string string String
    // 030 Description                              0001866722E0 ModelPrimitiveType string string string String
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

            value.ItemId                                    = GetString(new IntPtr(p + 0x010)); // 02466B542A20 0x10 ItemId                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ItemName                                  = GetString(new IntPtr(p + 0x018)); // 02466B542A40 0x18 ItemName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.UnitPrice                                 = GetInt32(new IntPtr(p + 0x020)); // 02466B542A60 0x20 UnitPrice                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Quantity                                  = GetInt32(new IntPtr(p + 0x024)); // 02466B542A80 0x24 Quantity                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ImageUrl                                  = GetString(new IntPtr(p + 0x028)); // 02466B542AA0 0x28 ImageUrl                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x030)); // 02466B542AC0 0x30 Description                 ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
