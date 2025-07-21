using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxSlot                                  ModelPrimitiveType int int int Int32
    // 014 CurrentSlot                              ModelPrimitiveType int int int Int32
    // 018 SelectedIndexList                        ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 GettableSkillList                        ModelClassListType IReadOnlyList`1<IPotentialSupportSkillStatus> IReadOnlyList`1<IPotentialSupportSkillStatus> List<IPotentialSupportSkillStatus> Pointer
    public partial class GetMultipleSupportSkillPopupViewModel : DataModel
    {
        public int                                      MaxSlot                                 { get; set; }
        public int                                      CurrentSlot                             { get; set; }
        public List<int>?                               SelectedIndexList                       { get; set; }
        public List<IPotentialSupportSkillStatus>?      GettableSkillList                       { get; set; }

        public static GetMultipleSupportSkillPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetMultipleSupportSkillPopupViewModel() { Pointer= p0 };

            value.MaxSlot                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 MaxSlot                     ( ModelPrimitiveType int int int Int32 )
            value.CurrentSlot                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 CurrentSlot                 ( ModelPrimitiveType int int int Int32 )
            value.SelectedIndexList                         = GetInt32List(new IntPtr(p + 0x018)); // 0x18 SelectedIndexList           ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.GettableSkillList                         = GetObjectList<IPotentialSupportSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPotentialSupportSkillStatus.FromPointer); // 0x20 GettableSkillList           ( ModelClassListType IReadOnlyList`1<IPotentialSupportSkillStatus> IReadOnlyList`1<IPotentialSupportSkillStatus> List<IPotentialSupportSkillStatus> Pointer )

            return value;
        }
    }
}
