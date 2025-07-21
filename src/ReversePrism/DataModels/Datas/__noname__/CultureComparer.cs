using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Converter                                ModelClassType CultureInfoConverter CultureInfoConverter CultureInfoConverter Pointer
    public partial class CultureComparer : DataModel
    {
        public CultureInfoConverter?                    Converter                               { get; set; }

        public static CultureComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CultureComparer() { Pointer= p0 };

            value.Converter                                 = GetObject<CultureInfoConverter>(new IntPtr(p + 0x010), ReversePrism.DataModels.CultureInfoConverter.FromPointer); // 0x10 Converter                   ( ModelClassType CultureInfoConverter CultureInfoConverter CultureInfoConverter Pointer )

            return value;
        }
    }
}
