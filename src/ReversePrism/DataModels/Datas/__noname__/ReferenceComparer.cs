using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Converter                                000186633770 ModelClassType ReferenceConverter ReferenceConverter ReferenceConverter Pointer
    public partial class ReferenceComparer
    {
        public ReferenceConverter?                      Converter                               { get; set; }

        public static ReferenceComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReferenceComparer();

            value.Converter                                 = GetObject<ReferenceConverter>(new IntPtr(p + 0x010), ReversePrism.DataModels.ReferenceConverter.FromPointer); // 0270D7B38FB8 0x10 Converter                   ( 000186633770 ModelClassType ReferenceConverter ReferenceConverter ReferenceConverter Pointer )

            return value;
        }
    }
}
