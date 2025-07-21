using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartTime                                ModelPrimitiveType float float float Single
    // 014 EndTime                                  ModelPrimitiveType float float float Single
    // 018 IsActivated                              ModelPrimitiveType bool bool bool Bool
    // 01C Duration                                 ModelPrimitiveType float float float Single
    public partial class RhythmGameLiveSkillEffect : DataModel
    {
        public float                                    StartTime                               { get; set; }
        public float                                    EndTime                                 { get; set; }
        public bool                                     IsActivated                             { get; set; }
        public float                                    Duration                                { get; set; }

        public static RhythmGameLiveSkillEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameLiveSkillEffect() { Pointer= p0 };

            value.StartTime                                 = GetSingle(new IntPtr(p + 0x010)); // 0x10 StartTime                   ( ModelPrimitiveType float float float Single )
            value.EndTime                                   = GetSingle(new IntPtr(p + 0x014)); // 0x14 EndTime                     ( ModelPrimitiveType float float float Single )
            value.IsActivated                               = GetBool(new IntPtr(p + 0x018)); // 0x18 IsActivated                 ( ModelPrimitiveType bool bool bool Bool )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Duration                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
