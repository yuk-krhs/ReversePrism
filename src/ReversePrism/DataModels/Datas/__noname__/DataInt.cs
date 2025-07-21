using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IntFormat                                ModelPrimitiveType bool bool bool Bool
    // 018 FrameData                                ModelClassListType FrameDataInt[] FrameDataInt[] List<FrameDataInt> Pointer
    public partial class DataInt : DataModel
    {
        public bool                                     IntFormat                               { get; set; }
        public List<FrameDataInt>?                      FrameData                               { get; set; }

        public static DataInt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataInt() { Pointer= p0 };

            value.IntFormat                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 IntFormat                   ( ModelPrimitiveType bool bool bool Bool )
            value.FrameData                                 = GetObjectList<FrameDataInt>(new IntPtr(p + 0x018), ReversePrism.DataModels.FrameDataInt.FromPointer); // 0x18 FrameData                   ( ModelClassListType FrameDataInt[] FrameDataInt[] List<FrameDataInt> Pointer )

            return value;
        }
    }
}
