using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Owner                                    0001865D3470 ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer
    // 018 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PropertyDescriptorEnumerator : DataModel
    {
        public PropertyDescriptorCollection?            Owner                                   { get; set; }
        public int                                      Index                                   { get; set; }

        public static PropertyDescriptorEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropertyDescriptorEnumerator() { Pointer= p0 };

            value.Owner                                     = GetObject<PropertyDescriptorCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.PropertyDescriptorCollection.FromPointer); // 024667BA0AE0 0x10 Owner                       ( 0001865D3470 ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 024667BA0B00 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
