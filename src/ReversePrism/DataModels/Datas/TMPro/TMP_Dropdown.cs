using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 M_Template                               000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 108 M_CaptionText                            000186613650 ModelClassType TMP_Text TMP_Text TMP_Text Pointer
    // 110 M_CaptionImage                           0001866CCDB0 ModelClassType Image Image Image Pointer
    // 118 M_Placeholder                            0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 120 M_ItemText                               000186613650 ModelClassType TMP_Text TMP_Text TMP_Text Pointer
    // 128 M_ItemImage                              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 130 M_Value                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 138 M_Options                                0001865E13A0 ModelClassType OptionDataList OptionDataList OptionDataList Pointer
    // 140 M_OnValueChanged                         0001865E0540 ModelClassType DropdownEvent DropdownEvent DropdownEvent Pointer
    // 148 M_AlphaFadeSpeed                         0001866656B0 ModelPrimitiveType float float float Single
    // 150 M_Dropdown                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 158 M_Blocker                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 160 M_Items                                  000185D2CFB8 ModelClassListType List`1<DropdownItem> List`1<DropdownItem> List<DropdownItem> Pointer
    // 168 m_AlphaTweenRunner                       TweenRunner`1<FloatTween> IL2CPP_TYPE_GENERICINST
    // 170 ValidTemplate                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 178 M_Coroutine                              000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer
    // 000 s_NoOptionData                           OptionData IL2CPP_TYPE_CLASS
    public partial class TMP_Dropdown : DataModel
    {
        public RectTransform?                           M_Template                              { get; set; }
        public TMP_Text?                                M_CaptionText                           { get; set; }
        public Image?                                   M_CaptionImage                          { get; set; }
        public Graphic?                                 M_Placeholder                           { get; set; }
        public TMP_Text?                                M_ItemText                              { get; set; }
        public Image?                                   M_ItemImage                             { get; set; }
        public int                                      M_Value                                 { get; set; }
        public OptionDataList?                          M_Options                               { get; set; }
        public DropdownEvent?                           M_OnValueChanged                        { get; set; }
        public float                                    M_AlphaFadeSpeed                        { get; set; }
        public GameObject?                              M_Dropdown                              { get; set; }
        public GameObject?                              M_Blocker                               { get; set; }
        public List<DropdownItem>?                      M_Items                                 { get; set; }
        public bool                                     ValidTemplate                           { get; set; }
        public Coroutine?                               M_Coroutine                             { get; set; }

        public static TMP_Dropdown? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_Dropdown() { Pointer= p0 };

            value.M_Template                                = GetObject<RectTransform>(new IntPtr(p + 0x100), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A67BC10 0x100 M_Template                  ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_CaptionText                             = GetObject<TMP_Text>(new IntPtr(p + 0x108), ReversePrism.DataModels.TMP_Text.FromPointer); // 02466A67BC30 0x108 M_CaptionText               ( 000186613650 ModelClassType TMP_Text TMP_Text TMP_Text Pointer )
            value.M_CaptionImage                            = GetObject<Image>(new IntPtr(p + 0x110), ReversePrism.DataModels.Image.FromPointer); // 02466A67BC50 0x110 M_CaptionImage              ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.M_Placeholder                             = GetObject<Graphic>(new IntPtr(p + 0x118), ReversePrism.DataModels.Graphic.FromPointer); // 02466A67BC70 0x118 M_Placeholder               ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.M_ItemText                                = GetObject<TMP_Text>(new IntPtr(p + 0x120), ReversePrism.DataModels.TMP_Text.FromPointer); // 02466A67BC90 0x120 M_ItemText                  ( 000186613650 ModelClassType TMP_Text TMP_Text TMP_Text Pointer )
            value.M_ItemImage                               = GetObject<Image>(new IntPtr(p + 0x128), ReversePrism.DataModels.Image.FromPointer); // 02466A67BCB0 0x128 M_ItemImage                 ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.M_Value                                   = GetInt32(new IntPtr(p + 0x130)); // 02466A67BCD0 0x130 M_Value                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Options                                 = GetObject<OptionDataList>(new IntPtr(p + 0x138), ReversePrism.DataModels.OptionDataList.FromPointer); // 02466A67BCF0 0x138 M_Options                   ( 0001865E13A0 ModelClassType OptionDataList OptionDataList OptionDataList Pointer )
            value.M_OnValueChanged                          = GetObject<DropdownEvent>(new IntPtr(p + 0x140), ReversePrism.DataModels.DropdownEvent.FromPointer); // 02466A67BD10 0x140 M_OnValueChanged            ( 0001865E0540 ModelClassType DropdownEvent DropdownEvent DropdownEvent Pointer )
            value.M_AlphaFadeSpeed                          = GetSingle(new IntPtr(p + 0x148)); // 02466A67BD30 0x148 M_AlphaFadeSpeed            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Dropdown                                = GetObject<GameObject>(new IntPtr(p + 0x150), ReversePrism.DataModels.GameObject.FromPointer); // 02466A67BD50 0x150 M_Dropdown                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.M_Blocker                                 = GetObject<GameObject>(new IntPtr(p + 0x158), ReversePrism.DataModels.GameObject.FromPointer); // 02466A67BD70 0x158 M_Blocker                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.M_Items                                   = GetObjectList<DropdownItem>(new IntPtr(p + 0x160), ReversePrism.DataModels.DropdownItem.FromPointer); // 02466A67BD90 0x160 M_Items                     ( 000185D2CFB8 ModelClassListType List`1<DropdownItem> List`1<DropdownItem> List<DropdownItem> Pointer )
            value.ValidTemplate                             = GetBool(new IntPtr(p + 0x170)); // 02466A67BDD0 0x170 ValidTemplate               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Coroutine                               = GetObject<Coroutine>(new IntPtr(p + 0x178), ReversePrism.DataModels.Coroutine.FromPointer); // 02466A67BDF0 0x178 M_Coroutine                 ( 000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer )

            return value;
        }
    }
}
