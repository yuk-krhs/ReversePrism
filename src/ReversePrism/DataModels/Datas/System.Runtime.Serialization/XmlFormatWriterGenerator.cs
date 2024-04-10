using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Helper                                   000186736C00 ModelClassType CriticalHelper CriticalHelper CriticalHelper Pointer
    public partial class XmlFormatWriterGenerator : DataModel
    {
        public CriticalHelper?                          Helper                                  { get; set; }

        public static XmlFormatWriterGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlFormatWriterGenerator() { Pointer= p0 };

            value.Helper                                    = GetObject<CriticalHelper>(new IntPtr(p + 0x010), ReversePrism.DataModels.CriticalHelper.FromPointer); // 024667DD6C78 0x10 Helper                      ( 000186736C00 ModelClassType CriticalHelper CriticalHelper CriticalHelper Pointer )

            return value;
        }
    }
}
