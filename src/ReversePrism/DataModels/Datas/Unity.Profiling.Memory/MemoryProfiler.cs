using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_SnapshotFinished                       Action`2<string, bool> IL2CPP_TYPE_GENERICINST
    // 008 m_SaveScreenshotToDisk                   Action`3<string, bool, DebugScreenCapture> IL2CPP_TYPE_GENERICINST
    // 010 CreatingMetadata                         Action`1<MemorySnapshotMetadata> IL2CPP_TYPE_GENERICINST
    public partial class MemoryProfiler : DataModel
    {

        public static MemoryProfiler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryProfiler() { Pointer= p0 };


            return value;
        }
    }
}
