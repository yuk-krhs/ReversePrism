using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CheckBox                                 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 ImgLabel                                 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 Value                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 OnChange                                 IObservable`1<ValueTuple`2<bool, int>> IL2CPP_TYPE_GENERICINST
    public partial class UICheckBox : DataModel
    {
        public ToggleButton?                            CheckBox                                { get; set; }
        public UIRawImage?                              ImgLabel                                { get; set; }
        public int                                      Value                                   { get; set; }

        public static UICheckBox? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UICheckBox() { Pointer= p0 };

            value.CheckBox                                  = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F82A8 0x20 CheckBox                    ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ImgLabel                                  = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0246654F82C8 0x28 ImgLabel                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.Value                                     = GetInt32(new IntPtr(p + 0x030)); // 0246654F82E8 0x30 Value                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
