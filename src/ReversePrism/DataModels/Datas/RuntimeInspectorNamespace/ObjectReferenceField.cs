using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ReferencePickerArea                      ModelClassType RectTransform RectTransform RectTransform Pointer
    // 088 Input                                    ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer
    // 090 InspectReferenceButton                   ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer
    // 098 InspectReferenceImage                    ModelClassType Image Image Image Pointer
    // 0A0 Background                               ModelClassType Image Image Image Pointer
    // 0A8 ReferenceNameText                        ModelClassType Text Text Text Pointer
    public partial class ObjectReferenceField : DataModel
    {
        public RectTransform?                           ReferencePickerArea                     { get; set; }
        public PointerEventListener?                    Input                                   { get; set; }
        public PointerEventListener?                    InspectReferenceButton                  { get; set; }
        public Image?                                   InspectReferenceImage                   { get; set; }
        public Image?                                   Background                              { get; set; }
        public Text?                                    ReferenceNameText                       { get; set; }

        public static ObjectReferenceField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectReferenceField() { Pointer= p0 };

            value.ReferencePickerArea                       = GetObject<RectTransform>(new IntPtr(p + 0x080), ReversePrism.DataModels.RectTransform.FromPointer); // 0x80 ReferencePickerArea         ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Input                                     = GetObject<PointerEventListener>(new IntPtr(p + 0x088), ReversePrism.DataModels.PointerEventListener.FromPointer); // 0x88 Input                       ( ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer )
            value.InspectReferenceButton                    = GetObject<PointerEventListener>(new IntPtr(p + 0x090), ReversePrism.DataModels.PointerEventListener.FromPointer); // 0x90 InspectReferenceButton      ( ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer )
            value.InspectReferenceImage                     = GetObject<Image>(new IntPtr(p + 0x098), ReversePrism.DataModels.Image.FromPointer); // 0x98 InspectReferenceImage       ( ModelClassType Image Image Image Pointer )
            value.Background                                = GetObject<Image>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Image.FromPointer); // 0xA0 Background                  ( ModelClassType Image Image Image Pointer )
            value.ReferenceNameText                         = GetObject<Text>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Text.FromPointer); // 0xA8 ReferenceNameText           ( ModelClassType Text Text Text Pointer )

            return value;
        }
    }
}
