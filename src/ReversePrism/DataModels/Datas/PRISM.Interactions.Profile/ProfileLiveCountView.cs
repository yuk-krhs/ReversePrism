using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CountTexts                               ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 028 Format                                   ModelPrimitiveType string string string String
    public partial class ProfileLiveCountView : DataModel
    {
        public List<UITextMeshProUGUI>?                 CountTexts                              { get; set; }
        public string                                   Format                                  { get; set; }

        public static ProfileLiveCountView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileLiveCountView() { Pointer= p0 };

            value.CountTexts                                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 CountTexts                  ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.Format                                    = GetString(new IntPtr(p + 0x028)); // 0x28 Format                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
