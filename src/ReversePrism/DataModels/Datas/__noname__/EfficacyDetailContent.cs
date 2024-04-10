using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentRectTransform                     000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 EfficacyName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 EfficacyDescription                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class EfficacyDetailContent : DataModel
    {
        public RectTransform?                           ContentRectTransform                    { get; set; }
        public UITextMeshProUGUI?                       EfficacyName                            { get; set; }
        public UITextMeshProUGUI?                       EfficacyDescription                     { get; set; }

        public static EfficacyDetailContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EfficacyDetailContent() { Pointer= p0 };

            value.ContentRectTransform                      = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 024664B7EEE0 0x20 ContentRectTransform        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.EfficacyName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664B7EF00 0x28 EfficacyName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EfficacyDescription                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664B7EF20 0x30 EfficacyDescription         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
