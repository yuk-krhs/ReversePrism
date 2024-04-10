using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Description                              000186671910 ModelPrimitiveType string string string String
    // 020 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 024 Level                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 028 LevelId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 030 Effects                                  000185D01108 ModelClassListType IReadOnlyList`1<ILiveSkillEffectStatus> IReadOnlyList`1<ILiveSkillEffectStatus> List<ILiveSkillEffectStatus> Pointer
    public partial class LiveSkill : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Description                             { get; set; }
        public int                                      Id                                      { get; set; }
        public int                                      Level                                   { get; set; }
        public int                                      LevelId                                 { get; set; }
        public List<ILiveSkillEffectStatus>?            Effects                                 { get; set; }

        public static LiveSkill? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSkill() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 024665018E38 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x018)); // 024665018E58 0x18 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Id                                        = GetInt32(new IntPtr(p + 0x020)); // 024665018E78 0x20 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x024)); // 024665018E98 0x24 Level                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LevelId                                   = GetInt32(new IntPtr(p + 0x028)); // 024665018EB8 0x28 LevelId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Effects                                   = GetObjectList<ILiveSkillEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ILiveSkillEffectStatus.FromPointer); // 024665018ED8 0x30 Effects                     ( 000185D01108 ModelClassListType IReadOnlyList`1<ILiveSkillEffectStatus> IReadOnlyList`1<ILiveSkillEffectStatus> List<ILiveSkillEffectStatus> Pointer )

            return value;
        }
    }
}
