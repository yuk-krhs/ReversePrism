using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnceDisplayedResult                      000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class LiveEventSaveData
    {
        public List<int>?                               OnceDisplayedResult                     { get; set; }

        public static LiveEventSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventSaveData();

            value.OnceDisplayedResult                       = GetInt32List(new IntPtr(p + 0x010)); // 027003A6AC58 0x10 OnceDisplayedResult         ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
