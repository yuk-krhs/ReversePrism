using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 target                                   <object> IL2CPP_TYPE_OBJECT
    // 090 Property                                 ModelClassType PropertyDescriptor PropertyDescriptor PropertyDescriptor Pointer
    public partial class WrappedPropertyDescriptor : DataModel
    {
        public PropertyDescriptor?                      Property                                { get; set; }

        public static WrappedPropertyDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WrappedPropertyDescriptor() { Pointer= p0 };

            value.Property                                  = GetObject<PropertyDescriptor>(new IntPtr(p + 0x090), ReversePrism.DataModels.PropertyDescriptor.FromPointer); // 0x90 Property                    ( ModelClassType PropertyDescriptor PropertyDescriptor PropertyDescriptor Pointer )

            return value;
        }
    }
}
