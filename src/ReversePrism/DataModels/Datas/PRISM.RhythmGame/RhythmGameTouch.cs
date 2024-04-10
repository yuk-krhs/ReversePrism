using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TouchPhase                               000186690510 ModelEnumType TouchPhase TouchPhase TouchPhase Int32
    // 014 LaneIndex                                000186666050 ModelPrimitiveType float float float Single
    // 018 PrevLaneIndex                            000186666050 ModelPrimitiveType float float float Single
    // 01C FlickDirection                           0001865A3FF0 ModelEnumType FlickDirection FlickDirection FlickDirection Int32
    // 020 IsConsumed                               000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class RhythmGameTouch : DataModel
    {
        public TouchPhase                               TouchPhase                              { get; set; }
        public float                                    LaneIndex                               { get; set; }
        public float                                    PrevLaneIndex                           { get; set; }
        public FlickDirection                           FlickDirection                          { get; set; }
        public bool                                     IsConsumed                              { get; set; }

        public static RhythmGameTouch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameTouch() { Pointer= p0 };

            value.TouchPhase                                = (TouchPhase)GetInt32(new IntPtr(p + 0x010)); // 024664FEEC20 0x10 TouchPhase                  ( 000186690510 ModelEnumType TouchPhase TouchPhase TouchPhase Int32 )
            value.LaneIndex                                 = GetSingle(new IntPtr(p + 0x014)); // 024664FEEC40 0x14 LaneIndex                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.PrevLaneIndex                             = GetSingle(new IntPtr(p + 0x018)); // 024664FEEC60 0x18 PrevLaneIndex               ( 000186666050 ModelPrimitiveType float float float Single )
            value.FlickDirection                            = (FlickDirection)GetInt32(new IntPtr(p + 0x01C)); // 024664FEEC80 0x1C FlickDirection              ( 0001865A3FF0 ModelEnumType FlickDirection FlickDirection FlickDirection Int32 )
            value.IsConsumed                                = GetBool(new IntPtr(p + 0x020)); // 024664FEECA0 0x20 IsConsumed                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
