using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Name                                   ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer
    // 020 M_Class                                  ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer
    public partial class UxmlRootElementTraits : DataModel
    {
        public UxmlStringAttributeDescription?          M_Name                                  { get; set; }
        public UxmlStringAttributeDescription?          M_Class                                 { get; set; }

        public static UxmlRootElementTraits? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UxmlRootElementTraits() { Pointer= p0 };

            value.M_Name                                    = GetObject<UxmlStringAttributeDescription>(new IntPtr(p + 0x018), ReversePrism.DataModels.UxmlStringAttributeDescription.FromPointer); // 0x18 M_Name                      ( ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer )
            value.M_Class                                   = GetObject<UxmlStringAttributeDescription>(new IntPtr(p + 0x020), ReversePrism.DataModels.UxmlStringAttributeDescription.FromPointer); // 0x20 M_Class                     ( ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer )

            return value;
        }
    }
}
