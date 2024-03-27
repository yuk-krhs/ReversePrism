using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   000186749310 ModelClassType ICustomTypeDescriptor ICustomTypeDescriptor ICustomTypeDescriptor Pointer
    public partial class CustomTypeDescriptor
    {
        public ICustomTypeDescriptor?                   Parent                                  { get; set; }

        public static CustomTypeDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomTypeDescriptor();

            value.Parent                                    = GetObject<ICustomTypeDescriptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICustomTypeDescriptor.FromPointer); // 0270D7B187E0 0x10 Parent                      ( 000186749310 ModelClassType ICustomTypeDescriptor ICustomTypeDescriptor ICustomTypeDescriptor Pointer )

            return value;
        }
    }
}
