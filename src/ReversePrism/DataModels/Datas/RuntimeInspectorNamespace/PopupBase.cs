using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 POINTER_VALIDATE_INTERVAL                float IL2CPP_TYPE_R4
    // 020 BorderLayoutElement                      00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 028 Background                               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 Label                                    000186631E10 ModelClassType Text Text Text Pointer
    // 038 RectTransform                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 CanvasTransform                          000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 WorldCamera                              0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 050 Pointer                                  0001866424B0 ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 058 NextPointerValidation                    0001866656B0 ModelPrimitiveType float float float Single
    // 05C M_skinVersion                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 M_skin                                   0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer
    public partial class PopupBase : DataModel
    {
        public LayoutElement?                           BorderLayoutElement                     { get; set; }
        public Image?                                   Background                              { get; set; }
        public Text?                                    Label                                   { get; set; }
        public RectTransform?                           RectTransform                           { get; set; }
        public RectTransform?                           CanvasTransform                         { get; set; }
        public Camera?                                  WorldCamera                             { get; set; }
        public PointerEventData?                        Pointer                                 { get; set; }
        public float                                    NextPointerValidation                   { get; set; }
        public int                                      M_skinVersion                           { get; set; }
        public UISkin?                                  M_skin                                  { get; set; }

        public static PopupBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PopupBase() { Pointer= p0 };

            value.BorderLayoutElement                       = GetObject<LayoutElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.LayoutElement.FromPointer); // 02466B249120 0x20 BorderLayoutElement         ( 00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.Background                                = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 02466B249140 0x28 Background                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Label                                     = GetObject<Text>(new IntPtr(p + 0x030), ReversePrism.DataModels.Text.FromPointer); // 02466B249160 0x30 Label                       ( 000186631E10 ModelClassType Text Text Text Pointer )
            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B249180 0x38 RectTransform               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.CanvasTransform                           = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B2491A0 0x40 CanvasTransform             ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.WorldCamera                               = GetObject<Camera>(new IntPtr(p + 0x048), ReversePrism.DataModels.Camera.FromPointer); // 02466B2491C0 0x48 WorldCamera                 ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.Pointer                                   = GetObject<PointerEventData>(new IntPtr(p + 0x050), ReversePrism.DataModels.PointerEventData.FromPointer); // 02466B2491E0 0x50 Pointer                     ( 0001866424B0 ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.NextPointerValidation                     = GetSingle(new IntPtr(p + 0x058)); // 02466B249200 0x58 NextPointerValidation       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_skinVersion                             = GetInt32(new IntPtr(p + 0x05C)); // 02466B249220 0x5C M_skinVersion               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_skin                                    = GetObject<UISkin>(new IntPtr(p + 0x060), ReversePrism.DataModels.UISkin.FromPointer); // 02466B249240 0x60 M_skin                      ( 0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer )

            return value;
        }
    }
}
