using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   ModelClassType TypeDescriptionProvider TypeDescriptionProvider TypeDescriptionProvider Pointer
    // 018 EmptyDescriptor                          ModelClassType EmptyCustomTypeDescriptor EmptyCustomTypeDescriptor EmptyCustomTypeDescriptor Pointer
    public partial class TypeDescriptionProvider : DataModel
    {
        public TypeDescriptionProvider?                 Parent                                  { get; set; }
        public EmptyCustomTypeDescriptor?               EmptyDescriptor                         { get; set; }

        public static TypeDescriptionProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeDescriptionProvider() { Pointer= p0 };

            value.Parent                                    = GetObject<TypeDescriptionProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.TypeDescriptionProvider.FromPointer); // 0x10 Parent                      ( ModelClassType TypeDescriptionProvider TypeDescriptionProvider TypeDescriptionProvider Pointer )
            value.EmptyDescriptor                           = GetObject<EmptyCustomTypeDescriptor>(new IntPtr(p + 0x018), ReversePrism.DataModels.EmptyCustomTypeDescriptor.FromPointer); // 0x18 EmptyDescriptor             ( ModelClassType EmptyCustomTypeDescriptor EmptyCustomTypeDescriptor EmptyCustomTypeDescriptor Pointer )

            return value;
        }
    }
}
