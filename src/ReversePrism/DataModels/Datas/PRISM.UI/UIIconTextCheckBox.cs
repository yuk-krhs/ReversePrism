using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CheckBox                                 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 ImgLabel                                 ModelClassType UIImage UIImage UIImage Pointer
    // 030 GoMask                                   ModelClassType GameObject GameObject GameObject Pointer
    // 038 ImgMaskedInCircle                        ModelClassType UIImage UIImage UIImage Pointer
    // 040 Value                                    ModelPrimitiveType int int int Int32
    // 048 OnChange                                 IObservable`1<ValueTuple`2<bool, int>> IL2CPP_TYPE_GENERICINST
    public partial class UIIconTextCheckBox : DataModel
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
            var value   = new UIIconTextCheckBox() { Pointer= p0 };

            value.CheckBox                                  = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 CheckBox                    ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ImgLabel                                  = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 ImgLabel                    ( ModelClassType UIImage UIImage UIImage Pointer )
            value.GoMask                                    = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GoMask                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgMaskedInCircle                         = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0x38 ImgMaskedInCircle           ( ModelClassType UIImage UIImage UIImage Pointer )
            value.Value                                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 Value                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
