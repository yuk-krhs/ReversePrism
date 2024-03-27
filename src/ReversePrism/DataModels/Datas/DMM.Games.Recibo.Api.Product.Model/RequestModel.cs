using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Locale                                   000186671910 ModelPrimitiveType string string string String
    // 018 ProductIds                               000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class RequestModel
    {
        public string                                   Locale                                  { get; set; }
        public List<string>?                            ProductIds                              { get; set; }

        public static RequestModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestModel();

            value.Locale                                    = GetString(new IntPtr(p + 0x010)); // 027004D77A30 0x10 Locale                      ( 000186671910 ModelPrimitiveType string string string String )
            value.ProductIds                                = GetStringList(new IntPtr(p + 0x018)); // 027004D77A50 0x18 ProductIds                  ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
