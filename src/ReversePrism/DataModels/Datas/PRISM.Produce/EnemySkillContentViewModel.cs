using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EnemySkill                               ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer
    // 018 IconID                                   ModelPrimitiveType int int int Int32
    // 01C InGameType                               ModelEnumType InGameType InGameType InGameType Int32
    public partial class EnemySkillContentViewModel : DataModel
    {
        public IngameSkillModel?                        EnemySkill                              { get; set; }
        public int                                      IconID                                  { get; set; }
        public InGameType                               InGameType                              { get; set; }

        public static EnemySkillContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnemySkillContentViewModel() { Pointer= p0 };

            value.EnemySkill                                = GetObject<IngameSkillModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 0x10 EnemySkill                  ( ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer )
            value.IconID                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 IconID                      ( ModelPrimitiveType int int int Int32 )
            value.InGameType                                = (InGameType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C InGameType                  ( ModelEnumType InGameType InGameType InGameType Int32 )

            return value;
        }
    }
}
