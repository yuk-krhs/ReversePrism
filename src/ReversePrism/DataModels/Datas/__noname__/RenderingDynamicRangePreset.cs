using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 List                                     ModelEnumListType List`1<MaterialPresetItem> List`1<MaterialPresetItem> List<MaterialPresetItem> Pointer
    public partial class RenderingDynamicRangePreset : DataModel
    {
        public List<MaterialPresetItem>?                List                                    { get; set; }

        public static RenderingDynamicRangePreset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderingDynamicRangePreset() { Pointer= p0 };

            value.List                                      = GetEnumList<MaterialPresetItem>(new IntPtr(p + 0x018)); // 0x18 List                        ( ModelEnumListType List`1<MaterialPresetItem> List`1<MaterialPresetItem> List<MaterialPresetItem> Pointer )

            return value;
        }
    }
}
