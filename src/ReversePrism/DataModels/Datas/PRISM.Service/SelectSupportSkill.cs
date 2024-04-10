using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheSkillList                           000185CE5488 ModelClassListType List`1<IInProducePotentialSupportSkillStatus> List`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer
    // 018 ProduceAutoSettingModel                  000186530A50 ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer
    public partial class SelectSupportSkill : DataModel
    {
        public List<IInProducePotentialSupportSkillStatus>? CacheSkillList                          { get; set; }
        public ProduceAutoSettingModel?                 ProduceAutoSettingModel                 { get; set; }

        public static SelectSupportSkill? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectSupportSkill() { Pointer= p0 };

            value.CacheSkillList                            = GetObjectList<IInProducePotentialSupportSkillStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IInProducePotentialSupportSkillStatus.FromPointer); // 0246664C7C40 0x10 CacheSkillList              ( 000185CE5488 ModelClassListType List`1<IInProducePotentialSupportSkillStatus> List`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer )
            value.ProduceAutoSettingModel                   = GetObject<ProduceAutoSettingModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAutoSettingModel.FromPointer); // 0246664C7C60 0x18 ProduceAutoSettingModel     ( 000186530A50 ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer )

            return value;
        }
    }
}
