using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EnemySkill                               0001866E8430 ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer
    // 018 IconID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 01C InGameType                               000186602570 ModelEnumType InGameType InGameType InGameType Int32
    public partial class EnemySkillContentViewModel
    {
        public IngameSkillModel?                        EnemySkill                              { get; set; }
        public int                                      IconID                                  { get; set; }
        public InGameType                               InGameType                              { get; set; }

        public static EnemySkillContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnemySkillContentViewModel();

            value.EnemySkill                                = GetObject<IngameSkillModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 0270D59D8E20 0x10 EnemySkill                  ( 0001866E8430 ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer )
            value.IconID                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D59D8E40 0x18 IconID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.InGameType                                = (InGameType)GetInt32(new IntPtr(p + 0x01C)); // 0270D59D8E60 0x1C InGameType                  ( 000186602570 ModelEnumType InGameType InGameType InGameType Int32 )

            return value;
        }
    }
}
