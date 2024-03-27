using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Val                                      000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    public partial class TransformData
    {
        public List<Vector3>?                           Val                                     { get; set; }

        public static TransformData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformData();

            value.Val                                       = GetEnumList<Vector3>(new IntPtr(p + 0x010)); // 0270D34E2EC8 0x10 Val                         ( 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )

            return value;
        }
    }
}
