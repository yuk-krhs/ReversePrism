using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 deserializationDict                      Dictionary`2<SharePreBuildData, ShareDeserializationData> IL2CPP_TYPE_GENERICINST
    // 018 IsValid                                  ModelPrimitiveType bool bool bool Bool
    // 000 deserializationProfiler                  ProfilerMarker IL2CPP_TYPE_VALUETYPE
    public partial class PreBuildManager : DataModel
    {
        public bool                                     IsValid                                 { get; set; }

        public static PreBuildManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PreBuildManager() { Pointer= p0 };

            value.IsValid                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 IsValid                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
