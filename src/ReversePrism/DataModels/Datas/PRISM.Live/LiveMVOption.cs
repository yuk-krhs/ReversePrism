using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsLyricsOn                               000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class LiveMVOption
    {
        public bool                                     IsLyricsOn                              { get; set; }

        public static LiveMVOption? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVOption();

            value.IsLyricsOn                                = GetBool(new IntPtr(p + 0x020)); // 027003A71CE0 0x20 IsLyricsOn                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
