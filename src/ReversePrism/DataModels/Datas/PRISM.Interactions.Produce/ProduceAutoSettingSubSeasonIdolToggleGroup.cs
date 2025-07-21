using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ToggleButtonGroups                       ModelClassListType ToggleButtonGroup[] ToggleButtonGroup[] List<ToggleButtonGroup> Pointer
    public partial class ProduceAutoSettingSubSeasonIdolToggleGroup : DataModel
    {
        public List<ToggleButtonGroup>?                 ToggleButtonGroups                      { get; set; }

        public static ProduceAutoSettingSubSeasonIdolToggleGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoSettingSubSeasonIdolToggleGroup() { Pointer= p0 };

            value.ToggleButtonGroups                        = GetObjectList<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x20 ToggleButtonGroups          ( ModelClassListType ToggleButtonGroup[] ToggleButtonGroup[] List<ToggleButtonGroup> Pointer )

            return value;
        }
    }
}
