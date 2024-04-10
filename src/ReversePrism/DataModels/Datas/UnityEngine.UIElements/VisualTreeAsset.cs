using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LinkedVEAInTemplatePropertyName          string IL2CPP_TYPE_STRING
    // 018 M_ImportedWithErrors                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 M_ImportedWithWarnings                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 008 s_TemporarySlotInsertionPoints           Dictionary`2<string, VisualElement> IL2CPP_TYPE_GENERICINST
    // 020 M_Usings                                 000185D30D08 ModelEnumListType List`1<UsingEntry> List`1<UsingEntry> List<UsingEntry> Pointer
    // 028 InlineSheet                              0001865CD850 ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 030 M_VisualElementAssets                    000185D1BFF8 ModelClassListType List`1<VisualElementAsset> List`1<VisualElementAsset> List<VisualElementAsset> Pointer
    // 038 M_TemplateAssets                         000185D13668 ModelClassListType List`1<TemplateAsset> List`1<TemplateAsset> List<TemplateAsset> Pointer
    // 040 M_UxmlObjectEntries                      000185D30F38 ModelEnumListType List`1<UxmlObjectEntry> List`1<UxmlObjectEntry> List<UxmlObjectEntry> Pointer
    // 048 M_UxmlObjectIds                          000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 050 M_AssetEntries                           000185D305F8 ModelEnumListType List`1<AssetEntry> List`1<AssetEntry> List<AssetEntry> Pointer
    // 058 M_Slots                                  000185D308C8 ModelEnumListType List`1<SlotDefinition> List`1<SlotDefinition> List<SlotDefinition> Pointer
    // 060 M_ContentContainerId                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 M_ContentHash                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class VisualTreeAsset : DataModel
    {
        public bool                                     M_ImportedWithErrors                    { get; set; }
        public bool                                     M_ImportedWithWarnings                  { get; set; }
        public List<UsingEntry>?                        M_Usings                                { get; set; }
        public StyleSheet?                              InlineSheet                             { get; set; }
        public List<VisualElementAsset>?                M_VisualElementAssets                   { get; set; }
        public List<TemplateAsset>?                     M_TemplateAssets                        { get; set; }
        public List<UxmlObjectEntry>?                   M_UxmlObjectEntries                     { get; set; }
        public List<int>?                               M_UxmlObjectIds                         { get; set; }
        public List<AssetEntry>?                        M_AssetEntries                          { get; set; }
        public List<SlotDefinition>?                    M_Slots                                 { get; set; }
        public int                                      M_ContentContainerId                    { get; set; }
        public int                                      M_ContentHash                           { get; set; }

        public static VisualTreeAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualTreeAsset() { Pointer= p0 };

            value.M_ImportedWithErrors                      = GetBool(new IntPtr(p + 0x018)); // 0245A6815AB0 0x18 M_ImportedWithErrors        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ImportedWithWarnings                    = GetBool(new IntPtr(p + 0x019)); // 0245A6815AD0 0x19 M_ImportedWithWarnings      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Usings                                  = GetEnumList<UsingEntry>(new IntPtr(p + 0x020)); // 0245A6815B10 0x20 M_Usings                    ( 000185D30D08 ModelEnumListType List`1<UsingEntry> List`1<UsingEntry> List<UsingEntry> Pointer )
            value.InlineSheet                               = GetObject<StyleSheet>(new IntPtr(p + 0x028), ReversePrism.DataModels.StyleSheet.FromPointer); // 0245A6815B30 0x28 InlineSheet                 ( 0001865CD850 ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.M_VisualElementAssets                     = GetObjectList<VisualElementAsset>(new IntPtr(p + 0x030), ReversePrism.DataModels.VisualElementAsset.FromPointer); // 0245A6815B50 0x30 M_VisualElementAssets       ( 000185D1BFF8 ModelClassListType List`1<VisualElementAsset> List`1<VisualElementAsset> List<VisualElementAsset> Pointer )
            value.M_TemplateAssets                          = GetObjectList<TemplateAsset>(new IntPtr(p + 0x038), ReversePrism.DataModels.TemplateAsset.FromPointer); // 0245A6815B70 0x38 M_TemplateAssets            ( 000185D13668 ModelClassListType List`1<TemplateAsset> List`1<TemplateAsset> List<TemplateAsset> Pointer )
            value.M_UxmlObjectEntries                       = GetEnumList<UxmlObjectEntry>(new IntPtr(p + 0x040)); // 0245A6815B90 0x40 M_UxmlObjectEntries         ( 000185D30F38 ModelEnumListType List`1<UxmlObjectEntry> List`1<UxmlObjectEntry> List<UxmlObjectEntry> Pointer )
            value.M_UxmlObjectIds                           = GetInt32List(new IntPtr(p + 0x048)); // 0245A6815BB0 0x48 M_UxmlObjectIds             ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_AssetEntries                            = GetEnumList<AssetEntry>(new IntPtr(p + 0x050)); // 0245A6815BD0 0x50 M_AssetEntries              ( 000185D305F8 ModelEnumListType List`1<AssetEntry> List`1<AssetEntry> List<AssetEntry> Pointer )
            value.M_Slots                                   = GetEnumList<SlotDefinition>(new IntPtr(p + 0x058)); // 0245A6815BF0 0x58 M_Slots                     ( 000185D308C8 ModelEnumListType List`1<SlotDefinition> List`1<SlotDefinition> List<SlotDefinition> Pointer )
            value.M_ContentContainerId                      = GetInt32(new IntPtr(p + 0x060)); // 0245A6815C10 0x60 M_ContentContainerId        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ContentHash                             = GetInt32(new IntPtr(p + 0x064)); // 0245A6815C30 0x64 M_ContentHash               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
