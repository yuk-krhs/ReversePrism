using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SpriteRenderer                           000186552360 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    public partial class SpriteNoteBase
    {
        public SpriteRenderer?                          SpriteRenderer                          { get; set; }

        public static SpriteNoteBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteNoteBase();

            value.SpriteRenderer                            = GetObject<SpriteRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0270D4F9E098 0x20 SpriteRenderer              ( 000186552360 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )

            return value;
        }
    }
}
