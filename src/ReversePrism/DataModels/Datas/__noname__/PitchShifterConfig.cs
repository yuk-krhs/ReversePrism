using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mode                                     ModelPrimitiveType int int int Int32
    // 014 WindowSize                               ModelPrimitiveType int int int Int32
    // 018 OverlapTimes                             ModelPrimitiveType int int int Int32
    public partial class PitchShifterConfig : DataModel
    {
        public int                                      Mode                                    { get; set; }
        public int                                      WindowSize                              { get; set; }
        public int                                      OverlapTimes                            { get; set; }

        public static PitchShifterConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PitchShifterConfig() { Pointer= p0 };

            value.Mode                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Mode                        ( ModelPrimitiveType int int int Int32 )
            value.WindowSize                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 WindowSize                  ( ModelPrimitiveType int int int Int32 )
            value.OverlapTimes                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 OverlapTimes                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
