using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Influence                                ModelPrimitiveType float float float Single
    // 014 Frequency                                ModelPrimitiveType float float float Single
    // 018 Turbulence                               ModelPrimitiveType float float float Single
    // 01C Blend                                    ModelPrimitiveType float float float Single
    // 020 Synchronization                          ModelPrimitiveType float float float Single
    // 024 DepthWeight                              ModelPrimitiveType float float float Single
    // 028 MovingWind                               ModelPrimitiveType float float float Single
    public partial class WindSettings : DataModel
    {
        public float                                    Influence                               { get; set; }
        public float                                    Frequency                               { get; set; }
        public float                                    Turbulence                              { get; set; }
        public float                                    Blend                                   { get; set; }
        public float                                    Synchronization                         { get; set; }
        public float                                    DepthWeight                             { get; set; }
        public float                                    MovingWind                              { get; set; }

        public static WindSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WindSettings() { Pointer= p0 };

            value.Influence                                 = GetSingle(new IntPtr(p + 0x010)); // 0x10 Influence                   ( ModelPrimitiveType float float float Single )
            value.Frequency                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 Frequency                   ( ModelPrimitiveType float float float Single )
            value.Turbulence                                = GetSingle(new IntPtr(p + 0x018)); // 0x18 Turbulence                  ( ModelPrimitiveType float float float Single )
            value.Blend                                     = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Blend                       ( ModelPrimitiveType float float float Single )
            value.Synchronization                           = GetSingle(new IntPtr(p + 0x020)); // 0x20 Synchronization             ( ModelPrimitiveType float float float Single )
            value.DepthWeight                               = GetSingle(new IntPtr(p + 0x024)); // 0x24 DepthWeight                 ( ModelPrimitiveType float float float Single )
            value.MovingWind                                = GetSingle(new IntPtr(p + 0x028)); // 0x28 MovingWind                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
