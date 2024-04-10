using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstIdolSkillId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 014 CurrentSkillLv                           0001865F4260 ModelPrimitiveType int int int Int32
    // 018 IconId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 020 <SkillLvInfoList>k__BackingField         IEnumerable`1<IdolSkillLevelViewModel> IL2CPP_TYPE_GENERICINST
    // 028 AppealTypeList                           000185D18D28 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    public partial class IdolSkillDetailListPopupViewModel : DataModel
    {
        public int                                      MstIdolSkillId                          { get; set; }
        public int                                      CurrentSkillLv                          { get; set; }
        public int                                      IconId                                  { get; set; }
        public List<ProduceParameterType>?              AppealTypeList                          { get; set; }

        public static IdolSkillDetailListPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillDetailListPopupViewModel() { Pointer= p0 };

            value.MstIdolSkillId                            = GetInt32(new IntPtr(p + 0x010)); // 0246662487F8 0x10 MstIdolSkillId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CurrentSkillLv                            = GetInt32(new IntPtr(p + 0x014)); // 024666248818 0x14 CurrentSkillLv              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x018)); // 024666248838 0x18 IconId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x028)); // 024666248878 0x28 AppealTypeList              ( 000185D18D28 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )

            return value;
        }
    }
}
