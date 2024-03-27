using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  CreationContext IL2CPP_TYPE_VALUETYPE
    // 010 Target                                   0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 VisualTreeAsset                          00018652C200 ModelClassType VisualTreeAsset VisualTreeAsset VisualTreeAsset Pointer
    // 020 <slotInsertionPoints>k__BackingField     Dictionary`2<string, VisualElement> IL2CPP_TYPE_GENERICINST
    // 028 AttributeOverrides                       000185D2D948 ModelEnumListType List`1<AttributeOverride> List`1<AttributeOverride> List<AttributeOverride> Pointer
    public partial class CreationContext
    {
        public VisualElement?                           Target                                  { get; set; }
        public VisualTreeAsset?                         VisualTreeAsset                         { get; set; }
        public List<AttributeOverride>?                 AttributeOverrides                      { get; set; }

        public static CreationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreationContext();

            value.Target                                    = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 027006858A88 0x10 Target                      ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.VisualTreeAsset                           = GetObject<VisualTreeAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualTreeAsset.FromPointer); // 027006858AA8 0x18 VisualTreeAsset             ( 00018652C200 ModelClassType VisualTreeAsset VisualTreeAsset VisualTreeAsset Pointer )
            value.AttributeOverrides                        = GetEnumList<AttributeOverride>(new IntPtr(p + 0x028)); // 027006858AE8 0x28 AttributeOverrides          ( 000185D2D948 ModelEnumListType List`1<AttributeOverride> List`1<AttributeOverride> List<AttributeOverride> Pointer )

            return value;
        }
    }
}
