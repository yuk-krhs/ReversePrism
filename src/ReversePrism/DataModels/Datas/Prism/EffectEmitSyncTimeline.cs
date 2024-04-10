using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StartEmissionRateOverDistance            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 EndEmissionRateOverDistance              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Timeline                                 00018666EA20 ModelClassType TimelineController TimelineController TimelineController Pointer
    // 030 Effect                                   00018671FD40 ModelClassType EffectController EffectController EffectController Pointer
    public partial class EffectEmitSyncTimeline : DataModel
    {
        public int                                      StartEmissionRateOverDistance           { get; set; }
        public int                                      EndEmissionRateOverDistance             { get; set; }
        public TimelineController?                      Timeline                                { get; set; }
        public EffectController?                        Effect                                  { get; set; }

        public static EffectEmitSyncTimeline? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EffectEmitSyncTimeline() { Pointer= p0 };

            value.StartEmissionRateOverDistance             = GetInt32(new IntPtr(p + 0x020)); // 024664F0C6C8 0x20 StartEmissionRateOverDistance ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndEmissionRateOverDistance               = GetInt32(new IntPtr(p + 0x024)); // 024664F0C6E8 0x24 EndEmissionRateOverDistance ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Timeline                                  = GetObject<TimelineController>(new IntPtr(p + 0x028), ReversePrism.DataModels.TimelineController.FromPointer); // 024664F0C708 0x28 Timeline                    ( 00018666EA20 ModelClassType TimelineController TimelineController TimelineController Pointer )
            value.Effect                                    = GetObject<EffectController>(new IntPtr(p + 0x030), ReversePrism.DataModels.EffectController.FromPointer); // 024664F0C728 0x30 Effect                      ( 00018671FD40 ModelClassType EffectController EffectController EffectController Pointer )

            return value;
        }
    }
}
