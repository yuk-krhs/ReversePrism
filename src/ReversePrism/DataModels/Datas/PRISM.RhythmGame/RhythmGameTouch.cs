using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TouchPhase                               ModelEnumType TouchPhase TouchPhase TouchPhase Int32
    // 014 LaneIndex                                ModelPrimitiveType float float float Single
    // 018 PrevLaneIndex                            ModelPrimitiveType float float float Single
    // 01C FlickDirection                           ModelEnumType FlickDirection FlickDirection FlickDirection Int32
    // 020 IsConsumed                               ModelPrimitiveType bool bool bool Bool
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

            value.TouchPhase                                = (TouchPhase)GetInt32(new IntPtr(p + 0x010)); // 0x10 TouchPhase                  ( ModelEnumType TouchPhase TouchPhase TouchPhase Int32 )
            value.LaneIndex                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 LaneIndex                   ( ModelPrimitiveType float float float Single )
            value.PrevLaneIndex                             = GetSingle(new IntPtr(p + 0x018)); // 0x18 PrevLaneIndex               ( ModelPrimitiveType float float float Single )
            value.FlickDirection                            = (FlickDirection)GetInt32(new IntPtr(p + 0x01C)); // 0x1C FlickDirection              ( ModelEnumType FlickDirection FlickDirection FlickDirection Int32 )
            value.IsConsumed                                = GetBool(new IntPtr(p + 0x020)); // 0x20 IsConsumed                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
