using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CustomTitle                              ModelPrimitiveType string string string String
    public partial class DisallowMultipleRendererFeature : DataModel
    {
        public string                                   CustomTitle                             { get; set; }

        public static DisallowMultipleRendererFeature? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisallowMultipleRendererFeature() { Pointer= p0 };

            value.CustomTitle                               = GetString(new IntPtr(p + 0x010)); // 0x10 CustomTitle                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
