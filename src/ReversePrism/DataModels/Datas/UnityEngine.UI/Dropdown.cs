using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 M_Template                               ModelClassType RectTransform RectTransform RectTransform Pointer
    // 108 M_CaptionText                            ModelClassType Text Text Text Pointer
    // 110 M_CaptionImage                           ModelClassType Image Image Image Pointer
    // 118 M_ItemText                               ModelClassType Text Text Text Pointer
    // 120 M_ItemImage                              ModelClassType Image Image Image Pointer
    // 128 M_Value                                  ModelPrimitiveType int int int Int32
    // 130 M_Options                                ModelClassType OptionDataList OptionDataList OptionDataList Pointer
    // 138 M_OnValueChanged                         ModelClassType DropdownEvent DropdownEvent DropdownEvent Pointer
    // 140 M_AlphaFadeSpeed                         ModelPrimitiveType float float float Single
    // 148 M_Dropdown                               ModelClassType GameObject GameObject GameObject Pointer
    // 150 M_Blocker                                ModelClassType GameObject GameObject GameObject Pointer
    // 158 M_Items                                  ModelClassListType List`1<DropdownItem> List`1<DropdownItem> List<DropdownItem> Pointer
    // 160 m_AlphaTweenRunner                       TweenRunner`1<FloatTween> IL2CPP_TYPE_GENERICINST
    // 168 ValidTemplate                            ModelPrimitiveType bool bool bool Bool
    // 000 kHighSortingLayer                        int IL2CPP_TYPE_I4
    // 000 s_NoOptionData                           OptionData IL2CPP_TYPE_CLASS
    public partial class Dropdown : DataModel
    {
        public RectTransform?                           M_Template                              { get; set; }
        public Text?                                    M_CaptionText                           { get; set; }
        public Image?                                   M_CaptionImage                          { get; set; }
        public Text?                                    M_ItemText                              { get; set; }
        public Image?                                   M_ItemImage                             { get; set; }
        public int                                      M_Value                                 { get; set; }
        public OptionDataList?                          M_Options                               { get; set; }
        public DropdownEvent?                           M_OnValueChanged                        { get; set; }
        public float                                    M_AlphaFadeSpeed                        { get; set; }
        public GameObject?                              M_Dropdown                              { get; set; }
        public GameObject?                              M_Blocker                               { get; set; }
        public List<DropdownItem>?                      M_Items                                 { get; set; }
        public bool                                     ValidTemplate                           { get; set; }

        public static Dropdown? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Dropdown() { Pointer= p0 };

            value.M_Template                                = GetObject<RectTransform>(new IntPtr(p + 0x100), ReversePrism.DataModels.RectTransform.FromPointer); // 0x100 M_Template                  ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_CaptionText                             = GetObject<Text>(new IntPtr(p + 0x108), ReversePrism.DataModels.Text.FromPointer); // 0x108 M_CaptionText               ( ModelClassType Text Text Text Pointer )
            value.M_CaptionImage                            = GetObject<Image>(new IntPtr(p + 0x110), ReversePrism.DataModels.Image.FromPointer); // 0x110 M_CaptionImage              ( ModelClassType Image Image Image Pointer )
            value.M_ItemText                                = GetObject<Text>(new IntPtr(p + 0x118), ReversePrism.DataModels.Text.FromPointer); // 0x118 M_ItemText                  ( ModelClassType Text Text Text Pointer )
            value.M_ItemImage                               = GetObject<Image>(new IntPtr(p + 0x120), ReversePrism.DataModels.Image.FromPointer); // 0x120 M_ItemImage                 ( ModelClassType Image Image Image Pointer )
            value.M_Value                                   = GetInt32(new IntPtr(p + 0x128)); // 0x128 M_Value                     ( ModelPrimitiveType int int int Int32 )
            value.M_Options                                 = GetObject<OptionDataList>(new IntPtr(p + 0x130), ReversePrism.DataModels.OptionDataList.FromPointer); // 0x130 M_Options                   ( ModelClassType OptionDataList OptionDataList OptionDataList Pointer )
            value.M_OnValueChanged                          = GetObject<DropdownEvent>(new IntPtr(p + 0x138), ReversePrism.DataModels.DropdownEvent.FromPointer); // 0x138 M_OnValueChanged            ( ModelClassType DropdownEvent DropdownEvent DropdownEvent Pointer )
            value.M_AlphaFadeSpeed                          = GetSingle(new IntPtr(p + 0x140)); // 0x140 M_AlphaFadeSpeed            ( ModelPrimitiveType float float float Single )
            value.M_Dropdown                                = GetObject<GameObject>(new IntPtr(p + 0x148), ReversePrism.DataModels.GameObject.FromPointer); // 0x148 M_Dropdown                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.M_Blocker                                 = GetObject<GameObject>(new IntPtr(p + 0x150), ReversePrism.DataModels.GameObject.FromPointer); // 0x150 M_Blocker                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.M_Items                                   = GetObjectList<DropdownItem>(new IntPtr(p + 0x158), ReversePrism.DataModels.DropdownItem.FromPointer); // 0x158 M_Items                     ( ModelClassListType List`1<DropdownItem> List`1<DropdownItem> List<DropdownItem> Pointer )
            value.ValidTemplate                             = GetBool(new IntPtr(p + 0x168)); // 0x168 ValidTemplate               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
