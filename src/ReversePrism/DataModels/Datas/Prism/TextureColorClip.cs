using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                00018664FDC0 ModelClassType TextureColorBehaviour TextureColorBehaviour TextureColorBehaviour Pointer
    public partial class TextureColorClip
    {
        public TextureColorBehaviour?                   Behaviour                               { get; set; }

        public static TextureColorClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureColorClip();

            value.Behaviour                                 = GetObject<TextureColorBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextureColorBehaviour.FromPointer); // 0270D4E002D8 0x18 Behaviour                   ( 00018664FDC0 ModelClassType TextureColorBehaviour TextureColorBehaviour TextureColorBehaviour Pointer )

            return value;
        }
    }
}
