using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgParent                                ModelClassType Transform Transform Transform Pointer
    // 028 BtnIdol                                  ModelClassType UIButton UIButton UIButton Pointer
    // 030 ColorTarget                              ModelClassType RawImage RawImage RawImage Pointer
    // 038 onTap                                    Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 040 onLongTap                                Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class IdolTapAreaView : DataModel
    {
        public Transform?                               ImgParent                               { get; set; }
        public UIButton?                                BtnIdol                                 { get; set; }
        public RawImage?                                ColorTarget                             { get; set; }

        public static IdolTapAreaView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolTapAreaView() { Pointer= p0 };

            value.ImgParent                                 = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 ImgParent                   ( ModelClassType Transform Transform Transform Pointer )
            value.BtnIdol                                   = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 BtnIdol                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ColorTarget                               = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 0x30 ColorTarget                 ( ModelClassType RawImage RawImage RawImage Pointer )

            return value;
        }
    }
}
