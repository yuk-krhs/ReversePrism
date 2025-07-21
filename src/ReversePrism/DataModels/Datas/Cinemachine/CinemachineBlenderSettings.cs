using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_CustomBlends                           ModelEnumListType CustomBlend[] CustomBlend[] List<CustomBlend> Pointer
    // 000 kBlendFromAnyCameraLabel                 string IL2CPP_TYPE_STRING
    public partial class CinemachineBlenderSettings : DataModel
    {
        public List<CustomBlend>?                       M_CustomBlends                          { get; set; }

        public static CinemachineBlenderSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineBlenderSettings() { Pointer= p0 };

            value.M_CustomBlends                            = GetEnumList<CustomBlend>(new IntPtr(p + 0x018)); // 0x18 M_CustomBlends              ( ModelEnumListType CustomBlend[] CustomBlend[] List<CustomBlend> Pointer )

            return value;
        }
    }
}
