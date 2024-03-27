using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FrameTiming                            000185B7FF10 ModelEnumListType FrameTiming[] FrameTiming[] List<FrameTiming> Pointer
    public partial class GpuTimeProvider
    {
        public List<FrameTiming>?                       M_FrameTiming                           { get; set; }

        public static GpuTimeProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GpuTimeProvider();

            value.M_FrameTiming                             = GetEnumList<FrameTiming>(new IntPtr(p + 0x010)); // 0270DB65C090 0x10 M_FrameTiming               ( 000185B7FF10 ModelEnumListType FrameTiming[] FrameTiming[] List<FrameTiming> Pointer )

            return value;
        }
    }
}
