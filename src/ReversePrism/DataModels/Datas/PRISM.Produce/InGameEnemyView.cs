using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CommonView                               0001866D6A90 ModelClassType InGamePlayerCommonView InGamePlayerCommonView InGamePlayerCommonView Pointer
    // 028 HandContent                              000186732140 ModelClassType EnemyHandContent EnemyHandContent EnemyHandContent Pointer
    // 030 EnemySkillContentListView                000186732D20 ModelClassType EnemySkillContentListView EnemySkillContentListView EnemySkillContentListView Pointer
    // 038 AssetTag                                 000186671910 ModelPrimitiveType string string string String
    public partial class InGameEnemyView
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
            var value   = new InGameEnemyView();

            value.CommonView                                = GetObject<InGamePlayerCommonView>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGamePlayerCommonView.FromPointer); // 0270D59D0DD0 0x20 CommonView                  ( 0001866D6A90 ModelClassType InGamePlayerCommonView InGamePlayerCommonView InGamePlayerCommonView Pointer )
            value.HandContent                               = GetObject<EnemyHandContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnemyHandContent.FromPointer); // 0270D59D0DF0 0x28 HandContent                 ( 000186732140 ModelClassType EnemyHandContent EnemyHandContent EnemyHandContent Pointer )
            value.EnemySkillContentListView                 = GetObject<EnemySkillContentListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.EnemySkillContentListView.FromPointer); // 0270D59D0E10 0x30 EnemySkillContentListView   ( 000186732D20 ModelClassType EnemySkillContentListView EnemySkillContentListView EnemySkillContentListView Pointer )
            value.AssetTag                                  = GetString(new IntPtr(p + 0x038)); // 0270D59D0E30 0x38 AssetTag                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
