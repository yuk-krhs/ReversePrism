using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Components                               000185D1C438 ModelClassListType List`1<VolumeComponent> List`1<VolumeComponent> List<VolumeComponent> Pointer
    // 020 IsDirty                                  000186597BE0 ModelPrimitiveType bool bool bool Bool
    public partial class VolumeProfile : DataModel
    {
        public List<VolumeComponent>?                   Components                              { get; set; }
        public bool                                     IsDirty                                 { get; set; }

        public static VolumeProfile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VolumeProfile() { Pointer= p0 };

            value.Components                                = GetObjectList<VolumeComponent>(new IntPtr(p + 0x018), ReversePrism.DataModels.VolumeComponent.FromPointer); // 024669324C10 0x18 Components                  ( 000185D1C438 ModelClassListType List`1<VolumeComponent> List`1<VolumeComponent> List<VolumeComponent> Pointer )
            value.IsDirty                                   = GetBool(new IntPtr(p + 0x020)); // 024669324C30 0x20 IsDirty                     ( 000186597BE0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
