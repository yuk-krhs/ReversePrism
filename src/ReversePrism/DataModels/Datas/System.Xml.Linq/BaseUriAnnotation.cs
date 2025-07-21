using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseUri                                  ModelPrimitiveType string string string String
    public partial class BaseUriAnnotation : DataModel
    {
        public string                                   BaseUri                                 { get; set; }

        public static BaseUriAnnotation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseUriAnnotation() { Pointer= p0 };

            value.BaseUri                                   = GetString(new IntPtr(p + 0x010)); // 0x10 BaseUri                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
