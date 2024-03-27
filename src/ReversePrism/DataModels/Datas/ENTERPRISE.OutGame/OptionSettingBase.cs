using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Parent                                   0001866E7A10 ModelClassType OptionPopupContent OptionPopupContent OptionPopupContent Pointer
    // 028 ButtomTextObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class OptionSettingBase
    {
        public OptionPopupContent?                      Parent                                  { get; set; }
        public GameObject?                              ButtomTextObject                        { get; set; }

        public static OptionSettingBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OptionSettingBase();

            value.Parent                                    = GetObject<OptionPopupContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.OptionPopupContent.FromPointer); // 0270D4C07A48 0x20 Parent                      ( 0001866E7A10 ModelClassType OptionPopupContent OptionPopupContent OptionPopupContent Pointer )
            value.ButtomTextObject                          = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4C07A68 0x28 ButtomTextObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
