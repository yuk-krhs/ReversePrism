using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IntFormat                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 FrameData                                000185CC12D8 ModelClassListType FrameDataInt[] FrameDataInt[] List<FrameDataInt> Pointer
    public partial class DataInt
    {
        public bool                                     IntFormat                               { get; set; }
        public List<FrameDataInt>?                      FrameData                               { get; set; }

        public static DataInt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataInt();

            value.IntFormat                                 = GetBool(new IntPtr(p + 0x010)); // 0270D4D99618 0x10 IntFormat                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FrameData                                 = GetObjectList<FrameDataInt>(new IntPtr(p + 0x018), ReversePrism.DataModels.FrameDataInt.FromPointer); // 0270D4D99638 0x18 FrameData                   ( 000185CC12D8 ModelClassListType FrameDataInt[] FrameDataInt[] List<FrameDataInt> Pointer )

            return value;
        }
    }
}
