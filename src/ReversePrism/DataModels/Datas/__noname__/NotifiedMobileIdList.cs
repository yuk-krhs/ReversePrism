using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _NotifiedMobileIdList                    000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class NotifiedMobileIdList
    {
        public List<int>?                               _NotifiedMobileIdList                   { get; set; }

        public static NotifiedMobileIdList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotifiedMobileIdList();

            value._NotifiedMobileIdList                     = GetInt32List(new IntPtr(p + 0x010)); // 0270075510B0 0x10 _NotifiedMobileIdList       ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
