using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 POINTER_VALIDATE_INTERVAL                float IL2CPP_TYPE_R4
    // 020 BorderLayoutElement                      ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 028 Background                               ModelClassType Image Image Image Pointer
    // 030 Label                                    ModelClassType Text Text Text Pointer
    // 038 RectTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 CanvasTransform                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 WorldCamera                              ModelClassType Camera Camera Camera Pointer
    // 050 Pointer                                  ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 058 NextPointerValidation                    ModelPrimitiveType float float float Single
    // 05C M_skinVersion                            ModelPrimitiveType int int int Int32
    // 060 M_skin                                   ModelClassType UISkin UISkin UISkin Pointer
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

            value.BorderLayoutElement                       = GetObject<LayoutElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.LayoutElement.FromPointer); // 0x20 BorderLayoutElement         ( ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.Background                                = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 Background                  ( ModelClassType Image Image Image Pointer )
            value.Label                                     = GetObject<Text>(new IntPtr(p + 0x030), ReversePrism.DataModels.Text.FromPointer); // 0x30 Label                       ( ModelClassType Text Text Text Pointer )
            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 RectTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.CanvasTransform                           = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 CanvasTransform             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.WorldCamera                               = GetObject<Camera>(new IntPtr(p + 0x048), ReversePrism.DataModels.Camera.FromPointer); // 0x48 WorldCamera                 ( ModelClassType Camera Camera Camera Pointer )
            value.Pointer                                   = GetObject<PointerEventData>(new IntPtr(p + 0x050), ReversePrism.DataModels.PointerEventData.FromPointer); // 0x50 Pointer                     ( ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.NextPointerValidation                     = GetSingle(new IntPtr(p + 0x058)); // 0x58 NextPointerValidation       ( ModelPrimitiveType float float float Single )
            value.M_skinVersion                             = GetInt32(new IntPtr(p + 0x05C)); // 0x5C M_skinVersion               ( ModelPrimitiveType int int int Int32 )
            value.M_skin                                    = GetObject<UISkin>(new IntPtr(p + 0x060), ReversePrism.DataModels.UISkin.FromPointer); // 0x60 M_skin                      ( ModelClassType UISkin UISkin UISkin Pointer )

            return value;
        }
    }
}
