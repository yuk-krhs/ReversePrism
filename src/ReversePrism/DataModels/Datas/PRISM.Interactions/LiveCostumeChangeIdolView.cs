using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolIconView                             000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 IdolSecondName                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 IdolName                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ClosedState                              000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 OpenState                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 NameArea                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 LiveIdolNameOpenSize                     0001866656B0 ModelPrimitiveType float float float Single
    // 054 MvIdolNameOpenSize                       0001866656B0 ModelPrimitiveType float float float Single
    // 058 CloseButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 OpenButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 068 CostumeIcons                             000185B77810 ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer
    // 070 ClosedStateSize                          0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 078 OpenStateSize                            0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class LiveCostumeChangeIdolView
    {
        public PFIdolIconView?                          IdolIconView                            { get; set; }
        public UITextMeshProUGUI?                       IdolSecondName                          { get; set; }
        public UITextMeshProUGUI?                       IdolName                                { get; set; }
        public RectTransform?                           ClosedState                             { get; set; }
        public RectTransform?                           OpenState                               { get; set; }
        public RectTransform?                           NameArea                                { get; set; }
        public float                                    LiveIdolNameOpenSize                    { get; set; }
        public float                                    MvIdolNameOpenSize                      { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public ButtonBase?                              OpenButton                              { get; set; }
        public List<CostumeIcon>?                       CostumeIcons                            { get; set; }
        public Vector2                                  ClosedStateSize                         { get; set; }
        public Vector2                                  OpenStateSize                           { get; set; }

        public static LiveCostumeChangeIdolView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangeIdolView();

            value.IdolIconView                              = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DB3AD1D8 0x20 IdolIconView                ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.IdolSecondName                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB3AD1F8 0x28 IdolSecondName              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB3AD218 0x30 IdolName                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClosedState                               = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DB3AD238 0x38 ClosedState                 ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.OpenState                                 = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DB3AD258 0x40 OpenState                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.NameArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DB3AD278 0x48 NameArea                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LiveIdolNameOpenSize                      = GetSingle(new IntPtr(p + 0x050)); // 0270DB3AD298 0x50 LiveIdolNameOpenSize        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MvIdolNameOpenSize                        = GetSingle(new IntPtr(p + 0x054)); // 0270DB3AD2B8 0x54 MvIdolNameOpenSize          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DB3AD2D8 0x58 CloseButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.OpenButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DB3AD2F8 0x60 OpenButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.CostumeIcons                              = GetObjectList<CostumeIcon>(new IntPtr(p + 0x068), ReversePrism.DataModels.CostumeIcon.FromPointer); // 0270DB3AD318 0x68 CostumeIcons                ( 000185B77810 ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer )
            value.ClosedStateSize                           = (Vector2)GetInt32(new IntPtr(p + 0x070)); // 0270DB3AD338 0x70 ClosedStateSize             ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.OpenStateSize                             = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 0270DB3AD358 0x78 OpenStateSize               ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
