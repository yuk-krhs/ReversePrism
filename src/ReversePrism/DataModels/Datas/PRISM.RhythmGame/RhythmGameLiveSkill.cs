using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MasterId                                 ModelPrimitiveType int int int Int32
    // 018 Text                                     ModelPrimitiveType string string string String
    // 020 CasterIdol                               ModelClassType LiveIdol LiveIdol LiveIdol Pointer
    // 028 Effects                                  ModelClassListType RhythmGameLiveSkillEffect[] RhythmGameLiveSkillEffect[] List<RhythmGameLiveSkillEffect> Pointer
    // 030 IsEnable                                 ModelPrimitiveType bool bool bool Bool
    // 031 IsActivated                              ModelPrimitiveType bool bool bool Bool
    public partial class RhythmGameLiveSkill : DataModel
    {
        public int                                      MasterId                                { get; set; }
        public string                                   Text                                    { get; set; }
        public LiveIdol?                                CasterIdol                              { get; set; }
        public List<RhythmGameLiveSkillEffect>?         Effects                                 { get; set; }
        public bool                                     IsEnable                                { get; set; }
        public bool                                     IsActivated                             { get; set; }

        public static RhythmGameLiveSkill? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameLiveSkill() { Pointer= p0 };

            value.MasterId                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 MasterId                    ( ModelPrimitiveType int int int Int32 )
            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Text                        ( ModelPrimitiveType string string string String )
            value.CasterIdol                                = GetObject<LiveIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveIdol.FromPointer); // 0x20 CasterIdol                  ( ModelClassType LiveIdol LiveIdol LiveIdol Pointer )
            value.Effects                                   = GetObjectList<RhythmGameLiveSkillEffect>(new IntPtr(p + 0x028), ReversePrism.DataModels.RhythmGameLiveSkillEffect.FromPointer); // 0x28 Effects                     ( ModelClassListType RhythmGameLiveSkillEffect[] RhythmGameLiveSkillEffect[] List<RhythmGameLiveSkillEffect> Pointer )
            value.IsEnable                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 IsEnable                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsActivated                               = GetBool(new IntPtr(p + 0x031)); // 0x31 IsActivated                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
