using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdolStatus                               ModelClassType IPvpProduceIdolUnitStatus IPvpProduceIdolUnitStatus IPvpProduceIdolUnitStatus Pointer
    // 018 ProduceIdol                              ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer
    // 020 PIdolIcon                                ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    // 028 IdolSkill                                ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer
    // 030 VoDaViMeParameter                        ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    public partial class PvpPIdolUnitViewModel : DataModel
    {
        public IPvpProduceIdolUnitStatus?               IdolStatus                              { get; set; }
        public ProduceIdol?                             ProduceIdol                             { get; set; }
        public PIdolIcon?                               PIdolIcon                               { get; set; }
        public IIdolSkillStatus?                        IdolSkill                               { get; set; }
        public IProduceParameterStatus?                 VoDaViMeParameter                       { get; set; }

        public static PvpPIdolUnitViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPIdolUnitViewModel() { Pointer= p0 };

            value.IdolStatus                                = GetObject<IPvpProduceIdolUnitStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPvpProduceIdolUnitStatus.FromPointer); // 0x10 IdolStatus                  ( ModelClassType IPvpProduceIdolUnitStatus IPvpProduceIdolUnitStatus IPvpProduceIdolUnitStatus Pointer )
            value.ProduceIdol                               = GetObject<ProduceIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0x18 ProduceIdol                 ( ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer )
            value.PIdolIcon                                 = GetObject<PIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0x20 PIdolIcon                   ( ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.IdolSkill                                 = GetObject<IIdolSkillStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 0x28 IdolSkill                   ( ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer )
            value.VoDaViMeParameter                         = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x30 VoDaViMeParameter           ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )

            return value;
        }
    }
}
