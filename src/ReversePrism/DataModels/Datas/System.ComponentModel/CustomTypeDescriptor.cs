using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   ModelClassType ICustomTypeDescriptor ICustomTypeDescriptor ICustomTypeDescriptor Pointer
    public partial class CustomTypeDescriptor : DataModel
    {
        public ICustomTypeDescriptor?                   Parent                                  { get; set; }

        public static CustomTypeDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomTypeDescriptor() { Pointer= p0 };

            value.Parent                                    = GetObject<ICustomTypeDescriptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICustomTypeDescriptor.FromPointer); // 0x10 Parent                      ( ModelClassType ICustomTypeDescriptor ICustomTypeDescriptor ICustomTypeDescriptor Pointer )

            return value;
        }
    }
}
