using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Locale                                   ModelPrimitiveType string string string String
    // 018 ProductId                                ModelPrimitiveType string string string String
    // 020 Quantity                                 ModelPrimitiveType int int int Int32
    // 028 DeveloperPayload                         ModelPrimitiveType string string string String
    public partial class RequestModel : DataModel
    {
        public string                                   Locale                                  { get; set; }
        public string                                   ProductId                               { get; set; }
        public int                                      Quantity                                { get; set; }
        public string                                   DeveloperPayload                        { get; set; }

        public static RequestModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestModel() { Pointer= p0 };

            value.Locale                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Locale                      ( ModelPrimitiveType string string string String )
            value.ProductId                                 = GetString(new IntPtr(p + 0x018)); // 0x18 ProductId                   ( ModelPrimitiveType string string string String )
            value.Quantity                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 Quantity                    ( ModelPrimitiveType int int int Int32 )
            value.DeveloperPayload                          = GetString(new IntPtr(p + 0x028)); // 0x28 DeveloperPayload            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
