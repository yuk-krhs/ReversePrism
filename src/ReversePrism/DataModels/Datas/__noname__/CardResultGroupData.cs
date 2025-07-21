using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkillResultDatas                         ModelClassListType SkillResultData[] SkillResultData[] List<SkillResultData> Pointer
    public partial class CardResultGroupData : DataModel
    {
        public List<SkillResultData>?                   SkillResultDatas                        { get; set; }

        public static CardResultGroupData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardResultGroupData() { Pointer= p0 };

            value.SkillResultDatas                          = GetObjectList<SkillResultData>(new IntPtr(p + 0x010), ReversePrism.DataModels.SkillResultData.FromPointer); // 0x10 SkillResultDatas            ( ModelClassListType SkillResultData[] SkillResultData[] List<SkillResultData> Pointer )

            return value;
        }
    }
}
