using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ReferencePickerArea                      000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 088 Input                                    00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer
    // 090 InspectReferenceButton                   00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer
    // 098 InspectReferenceImage                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0A0 Background                               0001866CD000 ModelClassType Image Image Image Pointer
    // 0A8 ReferenceNameText                        000186631E10 ModelClassType Text Text Text Pointer
    public partial class ObjectReferenceField
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
            var value   = new ObjectReferenceField();

            value.ReferencePickerArea                       = GetObject<RectTransform>(new IntPtr(p + 0x080), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DB1E81C8 0x80 ReferencePickerArea         ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Input                                     = GetObject<PointerEventListener>(new IntPtr(p + 0x088), ReversePrism.DataModels.PointerEventListener.FromPointer); // 0270DB1E81E8 0x88 Input                       ( 00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer )
            value.InspectReferenceButton                    = GetObject<PointerEventListener>(new IntPtr(p + 0x090), ReversePrism.DataModels.PointerEventListener.FromPointer); // 0270DB1E8208 0x90 InspectReferenceButton      ( 00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer )
            value.InspectReferenceImage                     = GetObject<Image>(new IntPtr(p + 0x098), ReversePrism.DataModels.Image.FromPointer); // 0270DB1E8228 0x98 InspectReferenceImage       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Background                                = GetObject<Image>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Image.FromPointer); // 0270DB1E8248 0xA0 Background                  ( 0001866CD000 ModelClassType Image Image Image Pointer )
            value.ReferenceNameText                         = GetObject<Text>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Text.FromPointer); // 0270DB1E8268 0xA8 ReferenceNameText           ( 000186631E10 ModelClassType Text Text Text Pointer )

            return value;
        }
    }
}
