using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Helper                                   ModelClassType CriticalHelper CriticalHelper CriticalHelper Pointer
    public partial class JsonFormatWriterGenerator : DataModel
    {
        public CriticalHelper?                          Helper                                  { get; set; }

        public static JsonFormatWriterGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonFormatWriterGenerator() { Pointer= p0 };

            value.Helper                                    = GetObject<CriticalHelper>(new IntPtr(p + 0x010), ReversePrism.DataModels.CriticalHelper.FromPointer); // 0x10 Helper                      ( ModelClassType CriticalHelper CriticalHelper CriticalHelper Pointer )

            return value;
        }
    }
}
