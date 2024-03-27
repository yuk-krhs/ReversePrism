using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_compareInfo                            0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 000 Default                                  InvariantComparer IL2CPP_TYPE_CLASS
    public partial class InvariantComparer
    {
        public CompareInfo?                             M_compareInfo                           { get; set; }

        public static InvariantComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvariantComparer();

            value.M_compareInfo                             = GetObject<CompareInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompareInfo.FromPointer); // 0270D79845B0 0x10 M_compareInfo               ( 0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer )

            return value;
        }
    }
}
