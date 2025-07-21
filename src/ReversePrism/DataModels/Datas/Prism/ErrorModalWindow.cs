using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Root                                     ModelClassType GameObject GameObject GameObject Pointer
    // 028 OutsideButton                            ModelClassType Button Button Button Pointer
    // 030 MessageBody                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 MessageText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 MessageBackground                        ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 TimeToDisappear                          ModelPrimitiveType float float float Single
    // 04C MessageBodyExpandedSize                  ModelEnumType Vector2 Vector2 Vector2 Int32
    // 054 MessageBodyShrunkSize                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 060 ShowCanceller                            ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 068 HideCanceller                            ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 070 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    public partial class ErrorModalWindow : DataModel
    {
        public GameObject?                              Root                                    { get; set; }
        public Button?                                  OutsideButton                           { get; set; }
        public RectTransform?                           MessageBody                             { get; set; }
        public UITextMeshProUGUI?                       MessageText                             { get; set; }
        public RectTransform?                           MessageBackground                       { get; set; }
        public float                                    TimeToDisappear                         { get; set; }
        public Vector2                                  MessageBodyExpandedSize                 { get; set; }
        public Vector2                                  MessageBodyShrunkSize                   { get; set; }
        public AutoCancellationTokenSource              ShowCanceller                           { get; set; }
        public AutoCancellationTokenSource              HideCanceller                           { get; set; }
        public bool                                     IsInitialized                           { get; set; }

        public static ErrorModalWindow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorModalWindow() { Pointer= p0 };

            value.Root                                      = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 Root                        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OutsideButton                             = GetObject<Button>(new IntPtr(p + 0x028), ReversePrism.DataModels.Button.FromPointer); // 0x28 OutsideButton               ( ModelClassType Button Button Button Pointer )
            value.MessageBody                               = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 MessageBody                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 MessageText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MessageBackground                         = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 MessageBackground           ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.TimeToDisappear                           = GetSingle(new IntPtr(p + 0x048)); // 0x48 TimeToDisappear             ( ModelPrimitiveType float float float Single )
            value.MessageBodyExpandedSize                   = (Vector2)GetInt32(new IntPtr(p + 0x04C)); // 0x4C MessageBodyExpandedSize     ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.MessageBodyShrunkSize                     = (Vector2)GetInt32(new IntPtr(p + 0x054)); // 0x54 MessageBodyShrunkSize       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ShowCanceller                             = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x060)); // 0x60 ShowCanceller               ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.HideCanceller                             = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x068)); // 0x68 HideCanceller               ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x070)); // 0x70 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
