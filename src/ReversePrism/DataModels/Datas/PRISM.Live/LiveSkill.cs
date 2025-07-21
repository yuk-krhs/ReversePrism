using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Description                              ModelPrimitiveType string string string String
    // 020 Id                                       ModelPrimitiveType int int int Int32
    // 024 Level                                    ModelPrimitiveType int int int Int32
    // 028 LevelId                                  ModelPrimitiveType int int int Int32
    // 030 Effects                                  ModelClassListType IReadOnlyList`1<ILiveSkillEffectStatus> IReadOnlyList`1<ILiveSkillEffectStatus> List<ILiveSkillEffectStatus> Pointer
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x018)); // 0x18 Description                 ( ModelPrimitiveType string string string String )
            value.Id                                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Level                       ( ModelPrimitiveType int int int Int32 )
            value.LevelId                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 LevelId                     ( ModelPrimitiveType int int int Int32 )
            value.Effects                                   = GetObjectList<ILiveSkillEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ILiveSkillEffectStatus.FromPointer); // 0x30 Effects                     ( ModelClassListType IReadOnlyList`1<ILiveSkillEffectStatus> IReadOnlyList`1<ILiveSkillEffectStatus> List<ILiveSkillEffectStatus> Pointer )

            return value;
        }
    }
}
