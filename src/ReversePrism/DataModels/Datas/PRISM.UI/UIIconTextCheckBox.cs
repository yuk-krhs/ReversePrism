using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CheckBox                                 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 ImgLabel                                 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 GoMask                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 ImgMaskedInCircle                        0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 040 Value                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 OnChange                                 IObservable`1<ValueTuple`2<bool, int>> IL2CPP_TYPE_GENERICINST
    public partial class UIIconTextCheckBox
    {
        public ToggleButton?                            CheckBox                                { get; set; }
        public UIImage?                                 ImgLabel                                { get; set; }
        public GameObject?                              GoMask                                  { get; set; }
        public UIImage?                                 ImgMaskedInCircle                       { get; set; }
        public int                                      Value                                   { get; set; }

        public static UIIconTextCheckBox? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIIconTextCheckBox();

            value.CheckBox                                  = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D548FC58 0x20 CheckBox                    ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ImgLabel                                  = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270D548FC78 0x28 ImgLabel                    ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.GoMask                                    = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D548FC98 0x30 GoMask                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgMaskedInCircle                         = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0270D548FCB8 0x38 ImgMaskedInCircle           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Value                                     = GetInt32(new IntPtr(p + 0x040)); // 0270D548FCD8 0x40 Value                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
