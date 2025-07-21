using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <LiveStreamCache>k__BackingField         Dictionary`2<int, ILiveStreamProgramStatus> IL2CPP_TYPE_GENERICINST
    // 018 <ArchiveStreamCache>k__BackingField      Dictionary`2<int, IArchiveStreamProgramStatus> IL2CPP_TYPE_GENERICINST
    // 020 IsReady                                  ModelPrimitiveType bool bool bool Bool
    public partial class OurStreamCache : DataModel
    {
        public bool                                     IsReady                                 { get; set; }

        public static OurStreamCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamCache() { Pointer= p0 };

            value.IsReady                                   = GetBool(new IntPtr(p + 0x020)); // 0x20 IsReady                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
