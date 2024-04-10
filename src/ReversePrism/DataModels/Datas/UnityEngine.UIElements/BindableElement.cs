using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 3C8 Binding                                  0001867102A0 ModelClassType IBinding IBinding IBinding Pointer
    // 3D0 BindingPath                              000186671910 ModelPrimitiveType string string string String
    public partial class BindableElement : DataModel
    {
        public IBinding?                                Binding                                 { get; set; }
        public string                                   BindingPath                             { get; set; }

        public static BindableElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BindableElement() { Pointer= p0 };

            value.Binding                                   = GetObject<IBinding>(new IntPtr(p + 0x3C8), ReversePrism.DataModels.IBinding.FromPointer); // 0245A5022FC8 0x3C8 Binding                     ( 0001867102A0 ModelClassType IBinding IBinding IBinding Pointer )
            value.BindingPath                               = GetString(new IntPtr(p + 0x3D0)); // 0245A5022FE8 0x3D0 BindingPath                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
