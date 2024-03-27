using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartTime                                000186665B50 ModelPrimitiveType float float float Single
    // 014 EndTime                                  000186665B50 ModelPrimitiveType float float float Single
    // 018 IsActivated                              000186595480 ModelPrimitiveType bool bool bool Bool
    // 01C Duration                                 0001866656B0 ModelPrimitiveType float float float Single
    public partial class RhythmGameLiveSkillEffect
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
            var value   = new RhythmGameLiveSkillEffect();

            value.StartTime                                 = GetSingle(new IntPtr(p + 0x010)); // 0270D4F89F90 0x10 StartTime                   ( 000186665B50 ModelPrimitiveType float float float Single )
            value.EndTime                                   = GetSingle(new IntPtr(p + 0x014)); // 0270D4F89FB0 0x14 EndTime                     ( 000186665B50 ModelPrimitiveType float float float Single )
            value.IsActivated                               = GetBool(new IntPtr(p + 0x018)); // 0270D4F89FD0 0x18 IsActivated                 ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x01C)); // 0270D4F89FF0 0x1C Duration                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
