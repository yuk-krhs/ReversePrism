using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Data                                     000186671910 ModelPrimitiveType string string string String
    public partial class XmlCharacterData
    {
        public string                                   Data                                    { get; set; }

        public static XmlCharacterData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlCharacterData();

            value.Data                                      = GetString(new IntPtr(p + 0x020)); // 0270D744AE70 0x20 Data                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
