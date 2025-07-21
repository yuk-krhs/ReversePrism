using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _NotifiedMobileIdList                    ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class NotifiedMobileIdList : DataModel
    {
        public List<int>?                               _NotifiedMobileIdList                   { get; set; }

        public static NotifiedMobileIdList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotifiedMobileIdList() { Pointer= p0 };

            value._NotifiedMobileIdList                     = GetInt32List(new IntPtr(p + 0x010)); // 0x10 _NotifiedMobileIdList       ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
