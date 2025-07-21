using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_RootStyleClassName                     string IL2CPP_TYPE_STRING
    // 000 k_VisualElementNameSuffix                string IL2CPP_TYPE_STRING
    // 000 k_DefaultSortingOrder                    int IL2CPP_TYPE_I4
    // 000 s_CurrentUIDocumentCounter               int IL2CPP_TYPE_I4
    // 020 M_UIDocumentCreationIndex                ModelPrimitiveType int int int Int32
    // 028 M_PanelSettings                          ModelClassType PanelSettings PanelSettings PanelSettings Pointer
    // 030 M_PreviousPanelSettings                  ModelClassType PanelSettings PanelSettings PanelSettings Pointer
    // 038 M_ParentUI                               ModelClassType UIDocument UIDocument UIDocument Pointer
    // 040 M_ChildrenContent                        ModelClassType UIDocumentList UIDocumentList UIDocumentList Pointer
    // 048 M_ChildrenContentCopy                    ModelClassListType List`1<UIDocument> List`1<UIDocument> List<UIDocument> Pointer
    // 050 SourceAsset                              ModelClassType VisualTreeAsset VisualTreeAsset VisualTreeAsset Pointer
    // 058 M_RootVisualElement                      ModelClassType VisualElement VisualElement VisualElement Pointer
    // 060 M_FirstChildInsertIndex                  ModelPrimitiveType int int int Int32
    // 064 M_SortingOrder                           ModelPrimitiveType float float float Single
    public partial class UIDocument : DataModel
    {
        public int                                      M_UIDocumentCreationIndex               { get; set; }
        public PanelSettings?                           M_PanelSettings                         { get; set; }
        public PanelSettings?                           M_PreviousPanelSettings                 { get; set; }
        public UIDocument?                              M_ParentUI                              { get; set; }
        public UIDocumentList?                          M_ChildrenContent                       { get; set; }
        public List<UIDocument>?                        M_ChildrenContentCopy                   { get; set; }
        public VisualTreeAsset?                         SourceAsset                             { get; set; }
        public VisualElement?                           M_RootVisualElement                     { get; set; }
        public int                                      M_FirstChildInsertIndex                 { get; set; }
        public float                                    M_SortingOrder                          { get; set; }

        public static UIDocument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIDocument() { Pointer= p0 };

            value.M_UIDocumentCreationIndex                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_UIDocumentCreationIndex   ( ModelPrimitiveType int int int Int32 )
            value.M_PanelSettings                           = GetObject<PanelSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.PanelSettings.FromPointer); // 0x28 M_PanelSettings             ( ModelClassType PanelSettings PanelSettings PanelSettings Pointer )
            value.M_PreviousPanelSettings                   = GetObject<PanelSettings>(new IntPtr(p + 0x030), ReversePrism.DataModels.PanelSettings.FromPointer); // 0x30 M_PreviousPanelSettings     ( ModelClassType PanelSettings PanelSettings PanelSettings Pointer )
            value.M_ParentUI                                = GetObject<UIDocument>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIDocument.FromPointer); // 0x38 M_ParentUI                  ( ModelClassType UIDocument UIDocument UIDocument Pointer )
            value.M_ChildrenContent                         = GetObject<UIDocumentList>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIDocumentList.FromPointer); // 0x40 M_ChildrenContent           ( ModelClassType UIDocumentList UIDocumentList UIDocumentList Pointer )
            value.M_ChildrenContentCopy                     = GetObjectList<UIDocument>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIDocument.FromPointer); // 0x48 M_ChildrenContentCopy       ( ModelClassListType List`1<UIDocument> List`1<UIDocument> List<UIDocument> Pointer )
            value.SourceAsset                               = GetObject<VisualTreeAsset>(new IntPtr(p + 0x050), ReversePrism.DataModels.VisualTreeAsset.FromPointer); // 0x50 SourceAsset                 ( ModelClassType VisualTreeAsset VisualTreeAsset VisualTreeAsset Pointer )
            value.M_RootVisualElement                       = GetObject<VisualElement>(new IntPtr(p + 0x058), ReversePrism.DataModels.VisualElement.FromPointer); // 0x58 M_RootVisualElement         ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_FirstChildInsertIndex                   = GetInt32(new IntPtr(p + 0x060)); // 0x60 M_FirstChildInsertIndex     ( ModelPrimitiveType int int int Int32 )
            value.M_SortingOrder                            = GetSingle(new IntPtr(p + 0x064)); // 0x64 M_SortingOrder              ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
