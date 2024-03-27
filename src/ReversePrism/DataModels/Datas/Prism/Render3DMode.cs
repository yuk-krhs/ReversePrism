using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <DofOff>k__BackingField                  bool IL2CPP_TYPE_BOOLEAN
    // 001 <BloomOff>k__BackingField                bool IL2CPP_TYPE_BOOLEAN
    // 002 <LdrBloomOff>k__BackingField             bool IL2CPP_TYPE_BOOLEAN
    // 003 <SoftOverlayOff>k__BackingField          bool IL2CPP_TYPE_BOOLEAN
    // 004 <ColorGradingOff>k__BackingField         bool IL2CPP_TYPE_BOOLEAN
    // 005 <EdgeColorOff>k__BackingField            bool IL2CPP_TYPE_BOOLEAN
    // 006 <VignetteOff>k__BackingField             bool IL2CPP_TYPE_BOOLEAN
    // 007 <RadialBlurOff>k__BackingField           bool IL2CPP_TYPE_BOOLEAN
    public partial class Render3DMode
    {

        public static Render3DMode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Render3DMode();


            return value;
        }
    }
}
