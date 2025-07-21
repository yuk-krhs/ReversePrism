using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CommonView                               ModelClassType InGamePlayerCommonView InGamePlayerCommonView InGamePlayerCommonView Pointer
    // 028 HandContent                              ModelClassType EnemyHandContent EnemyHandContent EnemyHandContent Pointer
    // 030 EnemySkillContentListView                ModelClassType EnemySkillContentListView EnemySkillContentListView EnemySkillContentListView Pointer
    // 038 AssetTag                                 ModelPrimitiveType string string string String
    public partial class InGameEnemyView : DataModel
    {
        public InGamePlayerCommonView?                  CommonView                              { get; set; }
        public EnemyHandContent?                        HandContent                             { get; set; }
        public EnemySkillContentListView?               EnemySkillContentListView               { get; set; }
        public string                                   AssetTag                                { get; set; }

        public static InGameEnemyView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameEnemyView() { Pointer= p0 };

            value.CommonView                                = GetObject<InGamePlayerCommonView>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGamePlayerCommonView.FromPointer); // 0x20 CommonView                  ( ModelClassType InGamePlayerCommonView InGamePlayerCommonView InGamePlayerCommonView Pointer )
            value.HandContent                               = GetObject<EnemyHandContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnemyHandContent.FromPointer); // 0x28 HandContent                 ( ModelClassType EnemyHandContent EnemyHandContent EnemyHandContent Pointer )
            value.EnemySkillContentListView                 = GetObject<EnemySkillContentListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.EnemySkillContentListView.FromPointer); // 0x30 EnemySkillContentListView   ( ModelClassType EnemySkillContentListView EnemySkillContentListView EnemySkillContentListView Pointer )
            value.AssetTag                                  = GetString(new IntPtr(p + 0x038)); // 0x38 AssetTag                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
