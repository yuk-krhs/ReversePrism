using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgIcon                                  ModelClassType RawImage RawImage RawImage Pointer
    public partial class SkillSlotIconView : DataModel
    {
        public RawImage?                                ImgIcon                                 { get; set; }

        public static SkillSlotIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillSlotIconView() { Pointer= p0 };

            value.ImgIcon                                   = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 ImgIcon                     ( ModelClassType RawImage RawImage RawImage Pointer )

            return value;
        }
    }
}
