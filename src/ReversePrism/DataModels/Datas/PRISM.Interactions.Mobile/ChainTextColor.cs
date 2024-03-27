using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ColorIds                                 000185CB7498 ModelClassListType IdColorPair[] IdColorPair[] List<IdColorPair> Pointer
    public partial class ChainTextColor
    {
        public List<IdColorPair>?                       ColorIds                                { get; set; }

        public static ChainTextColor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTextColor();

            value.ColorIds                                  = GetObjectList<IdColorPair>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdColorPair.FromPointer); // 0270DB0E4C40 0x18 ColorIds                    ( 000185CB7498 ModelClassListType IdColorPair[] IdColorPair[] List<IdColorPair> Pointer )

            return value;
        }
    }
}
