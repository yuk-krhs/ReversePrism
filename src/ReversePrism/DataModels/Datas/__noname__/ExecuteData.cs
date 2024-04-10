using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkillDataList                            000185CB5918 ModelClassListType SkillData[] SkillData[] List<SkillData> Pointer
    // 018 Group                                    000186695BA0 ModelClassType CardResultGroupData CardResultGroupData CardResultGroupData Pointer
    public partial class ExecuteData : DataModel
    {
        public List<SkillData>?                         SkillDataList                           { get; set; }
        public CardResultGroupData?                     Group                                   { get; set; }

        public static ExecuteData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteData() { Pointer= p0 };

            value.SkillDataList                             = GetObjectList<SkillData>(new IntPtr(p + 0x010), ReversePrism.DataModels.SkillData.FromPointer); // 024665B01AB8 0x10 SkillDataList               ( 000185CB5918 ModelClassListType SkillData[] SkillData[] List<SkillData> Pointer )
            value.Group                                     = GetObject<CardResultGroupData>(new IntPtr(p + 0x018), ReversePrism.DataModels.CardResultGroupData.FromPointer); // 024665B01AD8 0x18 Group                       ( 000186695BA0 ModelClassType CardResultGroupData CardResultGroupData CardResultGroupData Pointer )

            return value;
        }
    }
}
