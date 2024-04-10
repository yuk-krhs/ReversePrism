using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mode                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 WindowSize                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 OverlapTimes                             0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.Mode                                      = GetInt32(new IntPtr(p + 0x010)); // 02466ACE1D00 0x10 Mode                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.WindowSize                                = GetInt32(new IntPtr(p + 0x014)); // 02466ACE1D20 0x14 WindowSize                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OverlapTimes                              = GetInt32(new IntPtr(p + 0x018)); // 02466ACE1D40 0x18 OverlapTimes                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
