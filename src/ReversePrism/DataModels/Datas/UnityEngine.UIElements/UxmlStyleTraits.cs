using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Name                                   00018675F2E0 ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer
    // 020 M_Path                                   00018675F2E0 ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer
    // 028 M_Src                                    00018675F2E0 ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer
    public partial class UxmlStyleTraits
    {
        public UxmlStringAttributeDescription?          M_Name                                  { get; set; }
        public UxmlStringAttributeDescription?          M_Path                                  { get; set; }
        public UxmlStringAttributeDescription?          M_Src                                   { get; set; }

        public static UxmlStyleTraits? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UxmlStyleTraits();

            value.M_Name                                    = GetObject<UxmlStringAttributeDescription>(new IntPtr(p + 0x018), ReversePrism.DataModels.UxmlStringAttributeDescription.FromPointer); // 02700684CF98 0x18 M_Name                      ( 00018675F2E0 ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer )
            value.M_Path                                    = GetObject<UxmlStringAttributeDescription>(new IntPtr(p + 0x020), ReversePrism.DataModels.UxmlStringAttributeDescription.FromPointer); // 02700684CFB8 0x20 M_Path                      ( 00018675F2E0 ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer )
            value.M_Src                                     = GetObject<UxmlStringAttributeDescription>(new IntPtr(p + 0x028), ReversePrism.DataModels.UxmlStringAttributeDescription.FromPointer); // 02700684CFD8 0x28 M_Src                       ( 00018675F2E0 ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer )

            return value;
        }
    }
}
