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
    public partial class EfficacyDetailContent
    {
        public RectTransform?                           ContentRectTransform                    { get; set; }
        public UITextMeshProUGUI?                       EfficacyName                            { get; set; }
        public UITextMeshProUGUI?                       EfficacyDescription                     { get; set; }

        public static EfficacyDetailContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EfficacyDetailContent();

            value.ContentRectTransform                      = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D4B18BA0 0x20 ContentRectTransform        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.EfficacyName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4B18BC0 0x28 EfficacyName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EfficacyDescription                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4B18BE0 0x30 EfficacyDescription         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
