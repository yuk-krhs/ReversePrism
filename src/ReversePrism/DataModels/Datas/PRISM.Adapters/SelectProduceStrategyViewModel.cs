using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceBaseInfo                          ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 018 ProduceStrategy                          ModelClassType IProduceStrategyStatus IProduceStrategyStatus IProduceStrategyStatus Pointer
    // 020 ProduceCardList                          ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 028 PotentialSupportSkill                    ModelClassType IGettablePotentialSupportSkillStatus IGettablePotentialSupportSkillStatus IGettablePotentialSupportSkillStatus Pointer
    public partial class SelectProduceStrategyViewModel : DataModel
    {
        public IProduceBaseInfoStatus?                  ProduceBaseInfo                         { get; set; }
        public IProduceStrategyStatus?                  ProduceStrategy                         { get; set; }
        public List<IProduceCardStatus>?                ProduceCardList                         { get; set; }
        public IGettablePotentialSupportSkillStatus?    PotentialSupportSkill                   { get; set; }

        public static SelectProduceStrategyViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectProduceStrategyViewModel() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x10 ProduceBaseInfo             ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.ProduceStrategy                           = GetObject<IProduceStrategyStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceStrategyStatus.FromPointer); // 0x18 ProduceStrategy             ( ModelClassType IProduceStrategyStatus IProduceStrategyStatus IProduceStrategyStatus Pointer )
            value.ProduceCardList                           = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x20 ProduceCardList             ( ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.PotentialSupportSkill                     = GetObject<IGettablePotentialSupportSkillStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IGettablePotentialSupportSkillStatus.FromPointer); // 0x28 PotentialSupportSkill       ( ModelClassType IGettablePotentialSupportSkillStatus IGettablePotentialSupportSkillStatus IGettablePotentialSupportSkillStatus Pointer )

            return value;
        }
    }
}
