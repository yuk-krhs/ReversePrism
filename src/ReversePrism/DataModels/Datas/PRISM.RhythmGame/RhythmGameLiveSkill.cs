using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MasterId                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Text                                     000186672F10 ModelPrimitiveType string string string String
    // 020 CasterFesIdolId                          000186672F10 ModelPrimitiveType string string string String
    // 028 Effects                                  000185CA14E8 ModelClassListType RhythmGameLiveSkillEffect[] RhythmGameLiveSkillEffect[] List<RhythmGameLiveSkillEffect> Pointer
    // 030 IsEnable                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 031 IsActivated                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RhythmGameLiveSkill
    {
        public int                                      MasterId                                { get; set; }
        public string                                   Text                                    { get; set; }
        public string                                   CasterFesIdolId                         { get; set; }
        public List<RhythmGameLiveSkillEffect>?         Effects                                 { get; set; }
        public bool                                     IsEnable                                { get; set; }
        public bool                                     IsActivated                             { get; set; }

        public static RhythmGameLiveSkill? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameLiveSkill();

            value.MasterId                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D4F8B298 0x10 MasterId                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 0270D4F8B2B8 0x18 Text                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.CasterFesIdolId                           = GetString(new IntPtr(p + 0x020)); // 0270D4F8B2D8 0x20 CasterFesIdolId             ( 000186672F10 ModelPrimitiveType string string string String )
            value.Effects                                   = GetObjectList<RhythmGameLiveSkillEffect>(new IntPtr(p + 0x028), ReversePrism.DataModels.RhythmGameLiveSkillEffect.FromPointer); // 0270D4F8B2F8 0x28 Effects                     ( 000185CA14E8 ModelClassListType RhythmGameLiveSkillEffect[] RhythmGameLiveSkillEffect[] List<RhythmGameLiveSkillEffect> Pointer )
            value.IsEnable                                  = GetBool(new IntPtr(p + 0x030)); // 0270D4F8B318 0x30 IsEnable                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsActivated                               = GetBool(new IntPtr(p + 0x031)); // 0270D4F8B338 0x31 IsActivated                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
