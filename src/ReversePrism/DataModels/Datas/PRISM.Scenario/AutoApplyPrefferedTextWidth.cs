using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MinWidth                                 ModelPrimitiveType float float float Single
    // 024 MaxWidth                                 ModelPrimitiveType float float float Single
    // 028 Mergin                                   ModelPrimitiveType float float float Single
    // 030 Text                                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 AppliedRectTransform                     ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class AutoApplyPrefferedTextWidth : DataModel
    {
        public float                                    MinWidth                                { get; set; }
        public float                                    MaxWidth                                { get; set; }
        public float                                    Mergin                                  { get; set; }
        public UITextMeshProUGUI?                       Text                                    { get; set; }
        public RectTransform?                           AppliedRectTransform                    { get; set; }

        public static AutoApplyPrefferedTextWidth? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoApplyPrefferedTextWidth() { Pointer= p0 };

            value.MinWidth                                  = GetSingle(new IntPtr(p + 0x020)); // 0x20 MinWidth                    ( ModelPrimitiveType float float float Single )
            value.MaxWidth                                  = GetSingle(new IntPtr(p + 0x024)); // 0x24 MaxWidth                    ( ModelPrimitiveType float float float Single )
            value.Mergin                                    = GetSingle(new IntPtr(p + 0x028)); // 0x28 Mergin                      ( ModelPrimitiveType float float float Single )
            value.Text                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 Text                        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AppliedRectTransform                      = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 AppliedRectTransform        ( ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
