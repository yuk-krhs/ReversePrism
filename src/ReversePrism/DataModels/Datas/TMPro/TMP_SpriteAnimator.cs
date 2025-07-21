using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 m_animations                             Dictionary`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 028 M_TextComponent                          ModelClassType TMP_Text TMP_Text TMP_Text Pointer
    public partial class TMP_SpriteAnimator : DataModel
    {
        public TMP_Text?                                M_TextComponent                         { get; set; }

        public static TMP_SpriteAnimator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_SpriteAnimator() { Pointer= p0 };

            value.M_TextComponent                           = GetObject<TMP_Text>(new IntPtr(p + 0x028), ReversePrism.DataModels.TMP_Text.FromPointer); // 0x28 M_TextComponent             ( ModelClassType TMP_Text TMP_Text TMP_Text Pointer )

            return value;
        }
    }
}
