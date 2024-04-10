using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 IconSpriteRenderer                       000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    public partial class SlideJointNote : DataModel
    {
        public SpriteRenderer?                          IconSpriteRenderer                      { get; set; }

        public static SlideJointNote? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SlideJointNote() { Pointer= p0 };

            value.IconSpriteRenderer                        = GetObject<SpriteRenderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 024665032E58 0x28 IconSpriteRenderer          ( 000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )

            return value;
        }
    }
}
