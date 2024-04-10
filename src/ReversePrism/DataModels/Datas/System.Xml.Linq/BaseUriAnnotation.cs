using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseUri                                  000186671BA0 ModelPrimitiveType string string string String
    public partial class BaseUriAnnotation : DataModel
    {
        public string                                   BaseUri                                 { get; set; }

        public static BaseUriAnnotation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseUriAnnotation() { Pointer= p0 };

            value.BaseUri                                   = GetString(new IntPtr(p + 0x010)); // 02466BCACC80 0x10 BaseUri                     ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
