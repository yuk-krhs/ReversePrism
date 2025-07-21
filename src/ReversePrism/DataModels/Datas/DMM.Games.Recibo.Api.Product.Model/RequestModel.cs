using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Locale                                   ModelPrimitiveType string string string String
    // 018 ProductIds                               ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class RequestModel : DataModel
    {
        public string                                   Locale                                  { get; set; }
        public List<string>?                            ProductIds                              { get; set; }

        public static RequestModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestModel() { Pointer= p0 };

            value.Locale                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Locale                      ( ModelPrimitiveType string string string String )
            value.ProductIds                                = GetStringList(new IntPtr(p + 0x018)); // 0x18 ProductIds                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
