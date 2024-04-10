using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSelected                               0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 OnSettings                               0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 020 Status                                   0001866EC8E0 ModelClassType IAchievementStatus IAchievementStatus IAchievementStatus Pointer
    // 028 SortFilterType                           000186669EE0 ModelEnumType AchievementCategoryType AchievementCategoryType AchievementCategoryType Int32
    // 02C IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 Master                                   000186618530 ModelClassType MstAchievement MstAchievement MstAchievement Pointer
    public partial class AchievementIconViewModel : DataModel
    {
        public BoolReactiveProperty?                    OnSelected                              { get; set; }
        public BoolReactiveProperty?                    OnSettings                              { get; set; }
        public IAchievementStatus?                      Status                                  { get; set; }
        public AchievementCategoryType                  SortFilterType                          { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public MstAchievement?                          Master                                  { get; set; }

        public static AchievementIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementIconViewModel() { Pointer= p0 };

            value.OnSelected                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 024665EC89F0 0x10 OnSelected                  ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.OnSettings                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 024665EC8A10 0x18 OnSettings                  ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.Status                                    = GetObject<IAchievementStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IAchievementStatus.FromPointer); // 024665EC8A30 0x20 Status                      ( 0001866EC8E0 ModelClassType IAchievementStatus IAchievementStatus IAchievementStatus Pointer )
            value.SortFilterType                            = (AchievementCategoryType)GetInt32(new IntPtr(p + 0x028)); // 024665EC8A50 0x28 SortFilterType              ( 000186669EE0 ModelEnumType AchievementCategoryType AchievementCategoryType AchievementCategoryType Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x02C)); // 024665EC8A70 0x2C IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Master                                    = GetObject<MstAchievement>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstAchievement.FromPointer); // 024665EC8A90 0x30 Master                      ( 000186618530 ModelClassType MstAchievement MstAchievement MstAchievement Pointer )

            return value;
        }
    }
}
