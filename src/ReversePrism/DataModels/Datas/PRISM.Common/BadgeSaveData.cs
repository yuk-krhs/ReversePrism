using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LastDateTimes                            000185B7E4D0 ModelPrimitiveListType long[] long[] List<long> Pointer
    public partial class BadgeSaveData
    {
        public List<long>?                              LastDateTimes                           { get; set; }

        public static BadgeSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BadgeSaveData();

            value.LastDateTimes                             = GetInt64List(new IntPtr(p + 0x020)); // 027003A70048 0x20 LastDateTimes               ( 000185B7E4D0 ModelPrimitiveListType long[] long[] List<long> Pointer )

            return value;
        }
    }
}
