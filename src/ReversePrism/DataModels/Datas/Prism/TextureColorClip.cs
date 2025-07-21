using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType TextureColorBehaviour TextureColorBehaviour TextureColorBehaviour Pointer
    public partial class TextureColorClip : DataModel
    {
        public TextureColorBehaviour?                   Behaviour                               { get; set; }

        public static TextureColorClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureColorClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<TextureColorBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextureColorBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType TextureColorBehaviour TextureColorBehaviour TextureColorBehaviour Pointer )

            return value;
        }
    }
}
