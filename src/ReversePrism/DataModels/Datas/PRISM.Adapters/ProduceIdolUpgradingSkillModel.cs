using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsLockedRP                               ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 IdolSkill                                ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer
    public partial class ProduceIdolUpgradingSkillModel : DataModel
    {
        public BoolReactiveProperty?                    IsLockedRP                              { get; set; }
        public IIdolSkillStatus?                        IdolSkill                               { get; set; }

        public static ProduceIdolUpgradingSkillModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolUpgradingSkillModel() { Pointer= p0 };

            value.IsLockedRP                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 IsLockedRP                  ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.IdolSkill                                 = GetObject<IIdolSkillStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 0x18 IdolSkill                   ( ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer )

            return value;
        }
    }
}
