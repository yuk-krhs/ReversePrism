using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Name                                   ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer
    // 020 M_Path                                   ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer
    // 028 M_Src                                    ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer
    public partial class UxmlStyleTraits : DataModel
    {
        public UxmlStringAttributeDescription?          M_Name                                  { get; set; }
        public UxmlStringAttributeDescription?          M_Path                                  { get; set; }
        public UxmlStringAttributeDescription?          M_Src                                   { get; set; }

        public static UxmlStyleTraits? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UxmlStyleTraits() { Pointer= p0 };

            value.M_Name                                    = GetObject<UxmlStringAttributeDescription>(new IntPtr(p + 0x018), ReversePrism.DataModels.UxmlStringAttributeDescription.FromPointer); // 0x18 M_Name                      ( ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer )
            value.M_Path                                    = GetObject<UxmlStringAttributeDescription>(new IntPtr(p + 0x020), ReversePrism.DataModels.UxmlStringAttributeDescription.FromPointer); // 0x20 M_Path                      ( ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer )
            value.M_Src                                     = GetObject<UxmlStringAttributeDescription>(new IntPtr(p + 0x028), ReversePrism.DataModels.UxmlStringAttributeDescription.FromPointer); // 0x28 M_Src                       ( ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer )

            return value;
        }
    }
}
