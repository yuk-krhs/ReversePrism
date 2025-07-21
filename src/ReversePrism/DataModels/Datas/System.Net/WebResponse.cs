using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_IsCacheFresh                           ModelPrimitiveType bool bool bool Bool
    // 019 M_IsFromCache                            ModelPrimitiveType bool bool bool Bool
    public partial class WebResponse : DataModel
    {
        public bool                                     M_IsCacheFresh                          { get; set; }
        public bool                                     M_IsFromCache                           { get; set; }

        public static WebResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebResponse() { Pointer= p0 };

            value.M_IsCacheFresh                            = GetBool(new IntPtr(p + 0x018)); // 0x18 M_IsCacheFresh              ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsFromCache                             = GetBool(new IntPtr(p + 0x019)); // 0x19 M_IsFromCache               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
