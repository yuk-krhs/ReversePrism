using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolIconView                             ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 IdolSecondName                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 IdolName                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ClosedState                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 OpenState                                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 NameArea                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 LiveIdolNameOpenSize                     ModelPrimitiveType float float float Single
    // 054 MvIdolNameOpenSize                       ModelPrimitiveType float float float Single
    // 058 CloseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 OpenButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 068 CostumeIcons                             ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer
    // 070 ClosedStateSize                          ModelEnumType Vector2 Vector2 Vector2 Int32
    // 078 OpenStateSize                            ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class LiveCostumeChangeIdolView : DataModel
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
            var value   = new LiveCostumeChangeIdolView() { Pointer= p0 };

            value.IdolIconView                              = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x20 IdolIconView                ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.IdolSecondName                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 IdolSecondName              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 IdolName                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClosedState                               = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 ClosedState                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.OpenState                                 = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 OpenState                   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.NameArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0x48 NameArea                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LiveIdolNameOpenSize                      = GetSingle(new IntPtr(p + 0x050)); // 0x50 LiveIdolNameOpenSize        ( ModelPrimitiveType float float float Single )
            value.MvIdolNameOpenSize                        = GetSingle(new IntPtr(p + 0x054)); // 0x54 MvIdolNameOpenSize          ( ModelPrimitiveType float float float Single )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x58 CloseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.OpenButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x60 OpenButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.CostumeIcons                              = GetObjectList<CostumeIcon>(new IntPtr(p + 0x068), ReversePrism.DataModels.CostumeIcon.FromPointer); // 0x68 CostumeIcons                ( ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer )
            value.ClosedStateSize                           = (Vector2)GetInt32(new IntPtr(p + 0x070)); // 0x70 ClosedStateSize             ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.OpenStateSize                             = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 0x78 OpenStateSize               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
