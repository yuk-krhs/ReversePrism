using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 INACTIVE_ITEM_TEXT_ALPHA                 float IL2CPP_TYPE_R4
    // 000 TEXT_X_OFFSET                            float IL2CPP_TYPE_R4
    // 038 ContentTransform                         000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 NameText                                 000186631C00 ModelClassType Text Text Text Pointer
    // 048 ClickListener                            00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer
    // 050 ExpandToggle                             00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer
    // 058 ExpandArrow                              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 060 MultiSelectionToggle                     000186682710 ModelClassType Toggle Toggle Toggle Pointer
    // 068 MultiSelectionToggleBackground           0001866CCDB0 ModelClassType Image Image Image Pointer
    // 070 RectTransform                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 078 Background                               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 080 M_skinVersion                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 M_skin                                   0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer
    // 090 M_isSelected                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 091 M_isActive                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 094 M_isExpanded                             000186537CA0 ModelEnumType ExpandedState ExpandedState ExpandedState Int32
    // 098 PreferredWidth                           0001866656B0 ModelPrimitiveType float float float Single
    // 0A0 Hierarchy                                000186699A60 ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer
    // 0A8 Data                                     0001866B3C40 ModelClassType HierarchyData HierarchyData HierarchyData Pointer
    public partial class HierarchyField : DataModel
    {
        public RectTransform?                           ContentTransform                        { get; set; }
        public Text?                                    NameText                                { get; set; }
        public PointerEventListener?                    ClickListener                           { get; set; }
        public PointerEventListener?                    ExpandToggle                            { get; set; }
        public Image?                                   ExpandArrow                             { get; set; }
        public Toggle?                                  MultiSelectionToggle                    { get; set; }
        public Image?                                   MultiSelectionToggleBackground          { get; set; }
        public RectTransform?                           RectTransform                           { get; set; }
        public Image?                                   Background                              { get; set; }
        public int                                      M_skinVersion                           { get; set; }
        public UISkin?                                  M_skin                                  { get; set; }
        public bool                                     M_isSelected                            { get; set; }
        public bool                                     M_isActive                              { get; set; }
        public ExpandedState                            M_isExpanded                            { get; set; }
        public float                                    PreferredWidth                          { get; set; }
        public RuntimeHierarchy?                        Hierarchy                               { get; set; }
        public HierarchyData?                           Data                                    { get; set; }

        public static HierarchyField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HierarchyField() { Pointer= p0 };

            value.ContentTransform                          = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B1E44E0 0x38 ContentTransform            ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.NameText                                  = GetObject<Text>(new IntPtr(p + 0x040), ReversePrism.DataModels.Text.FromPointer); // 02466B1E4500 0x40 NameText                    ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.ClickListener                             = GetObject<PointerEventListener>(new IntPtr(p + 0x048), ReversePrism.DataModels.PointerEventListener.FromPointer); // 02466B1E4520 0x48 ClickListener               ( 00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer )
            value.ExpandToggle                              = GetObject<PointerEventListener>(new IntPtr(p + 0x050), ReversePrism.DataModels.PointerEventListener.FromPointer); // 02466B1E4540 0x50 ExpandToggle                ( 00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer )
            value.ExpandArrow                               = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 02466B1E4560 0x58 ExpandArrow                 ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.MultiSelectionToggle                      = GetObject<Toggle>(new IntPtr(p + 0x060), ReversePrism.DataModels.Toggle.FromPointer); // 02466B1E4580 0x60 MultiSelectionToggle        ( 000186682710 ModelClassType Toggle Toggle Toggle Pointer )
            value.MultiSelectionToggleBackground            = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 02466B1E45A0 0x68 MultiSelectionToggleBackground ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x070), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B1E45C0 0x70 RectTransform               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Background                                = GetObject<Image>(new IntPtr(p + 0x078), ReversePrism.DataModels.Image.FromPointer); // 02466B1E45E0 0x78 Background                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.M_skinVersion                             = GetInt32(new IntPtr(p + 0x080)); // 02466B1E4600 0x80 M_skinVersion               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_skin                                    = GetObject<UISkin>(new IntPtr(p + 0x088), ReversePrism.DataModels.UISkin.FromPointer); // 02466B1E4620 0x88 M_skin                      ( 0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer )
            value.M_isSelected                              = GetBool(new IntPtr(p + 0x090)); // 02466B1E4640 0x90 M_isSelected                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_isActive                                = GetBool(new IntPtr(p + 0x091)); // 02466B1E4660 0x91 M_isActive                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_isExpanded                              = (ExpandedState)GetInt32(new IntPtr(p + 0x094)); // 02466B1E4680 0x94 M_isExpanded                ( 000186537CA0 ModelEnumType ExpandedState ExpandedState ExpandedState Int32 )
            value.PreferredWidth                            = GetSingle(new IntPtr(p + 0x098)); // 02466B1E46A0 0x98 PreferredWidth              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Hierarchy                                 = GetObject<RuntimeHierarchy>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.RuntimeHierarchy.FromPointer); // 02466B1E46C0 0xA0 Hierarchy                   ( 000186699A60 ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer )
            value.Data                                      = GetObject<HierarchyData>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.HierarchyData.FromPointer); // 02466B1E46E0 0xA8 Data                        ( 0001866B3C40 ModelClassType HierarchyData HierarchyData HierarchyData Pointer )

            return value;
        }
    }
}
