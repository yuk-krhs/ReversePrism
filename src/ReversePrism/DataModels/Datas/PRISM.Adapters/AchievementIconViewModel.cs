using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSelected                               ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 OnSettings                               ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 020 Status                                   ModelClassType IAchievementStatus IAchievementStatus IAchievementStatus Pointer
    // 028 SortFilterType                           ModelEnumType AchievementCategoryType AchievementCategoryType AchievementCategoryType Int32
    // 02C IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 030 Master                                   ModelClassType MstAchievement MstAchievement MstAchievement Pointer
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

            value.OnSelected                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 OnSelected                  ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.OnSettings                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x18 OnSettings                  ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.Status                                    = GetObject<IAchievementStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IAchievementStatus.FromPointer); // 0x20 Status                      ( ModelClassType IAchievementStatus IAchievementStatus IAchievementStatus Pointer )
            value.SortFilterType                            = (AchievementCategoryType)GetInt32(new IntPtr(p + 0x028)); // 0x28 SortFilterType              ( ModelEnumType AchievementCategoryType AchievementCategoryType AchievementCategoryType Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.Master                                    = GetObject<MstAchievement>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstAchievement.FromPointer); // 0x30 Master                      ( ModelClassType MstAchievement MstAchievement MstAchievement Pointer )

            return value;
        }
    }
}
