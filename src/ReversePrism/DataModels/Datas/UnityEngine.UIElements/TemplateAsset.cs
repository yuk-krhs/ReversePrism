using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 M_TemplateAlias                          ModelPrimitiveType string string string String
    // 078 M_AttributeOverrides                     ModelEnumListType List`1<AttributeOverride> List`1<AttributeOverride> List<AttributeOverride> Pointer
    // 080 M_SlotUsages                             ModelEnumListType List`1<SlotUsageEntry> List`1<SlotUsageEntry> List<SlotUsageEntry> Pointer
    public partial class TemplateAsset : DataModel
    {
        public string                                   M_TemplateAlias                         { get; set; }
        public List<AttributeOverride>?                 M_AttributeOverrides                    { get; set; }
        public List<SlotUsageEntry>?                    M_SlotUsages                            { get; set; }

        public static TemplateAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TemplateAsset() { Pointer= p0 };

            value.M_TemplateAlias                           = GetString(new IntPtr(p + 0x070)); // 0x70 M_TemplateAlias             ( ModelPrimitiveType string string string String )
            value.M_AttributeOverrides                      = GetEnumList<AttributeOverride>(new IntPtr(p + 0x078)); // 0x78 M_AttributeOverrides        ( ModelEnumListType List`1<AttributeOverride> List`1<AttributeOverride> List<AttributeOverride> Pointer )
            value.M_SlotUsages                              = GetEnumList<SlotUsageEntry>(new IntPtr(p + 0x080)); // 0x80 M_SlotUsages                ( ModelEnumListType List`1<SlotUsageEntry> List`1<SlotUsageEntry> List<SlotUsageEntry> Pointer )

            return value;
        }
    }
}
