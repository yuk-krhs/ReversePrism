using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Locale                                   000186671910 ModelPrimitiveType string string string String
    // 018 ProductId                                000186671910 ModelPrimitiveType string string string String
    // 020 Quantity                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 DeveloperPayload                         000186671910 ModelPrimitiveType string string string String
    public partial class RequestModel
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
            var value   = new RequestModel();

            value.Locale                                    = GetString(new IntPtr(p + 0x010)); // 0270DB47B318 0x10 Locale                      ( 000186671910 ModelPrimitiveType string string string String )
            value.ProductId                                 = GetString(new IntPtr(p + 0x018)); // 0270DB47B338 0x18 ProductId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Quantity                                  = GetInt32(new IntPtr(p + 0x020)); // 0270DB47B358 0x20 Quantity                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DeveloperPayload                          = GetString(new IntPtr(p + 0x028)); // 0270DB47B378 0x28 DeveloperPayload            ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
