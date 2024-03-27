using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Helper                                   000186736720 ModelClassType CriticalHelper CriticalHelper CriticalHelper Pointer
    public partial class XmlFormatReaderGenerator
    {
        public CriticalHelper?                          Helper                                  { get; set; }

        public static XmlFormatReaderGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlFormatReaderGenerator();

            value.Helper                                    = GetObject<CriticalHelper>(new IntPtr(p + 0x010), ReversePrism.DataModels.CriticalHelper.FromPointer); // 0270D7D6E708 0x10 Helper                      ( 000186736720 ModelClassType CriticalHelper CriticalHelper CriticalHelper Pointer )

            return value;
        }
    }
}
