using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Parent                                   ModelClassType OptionPopupContent OptionPopupContent OptionPopupContent Pointer
    // 028 ButtomTextObject                         ModelClassType GameObject GameObject GameObject Pointer
    public partial class OptionSettingBase : DataModel
    {
        public OptionPopupContent?                      Parent                                  { get; set; }
        public GameObject?                              ButtomTextObject                        { get; set; }

        public static OptionSettingBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OptionSettingBase() { Pointer= p0 };

            value.Parent                                    = GetObject<OptionPopupContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.OptionPopupContent.FromPointer); // 0x20 Parent                      ( ModelClassType OptionPopupContent OptionPopupContent OptionPopupContent Pointer )
            value.ButtomTextObject                          = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ButtomTextObject            ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
