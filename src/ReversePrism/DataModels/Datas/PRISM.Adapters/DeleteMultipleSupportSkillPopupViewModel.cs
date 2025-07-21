using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DeleteNum                                ModelPrimitiveType int int int Int32
    // 018 SelectedIndexList                        ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 SkillList                                ModelClassListType IReadOnlyList`1<IPotentialSupportSkillStatus> IReadOnlyList`1<IPotentialSupportSkillStatus> List<IPotentialSupportSkillStatus> Pointer
    public partial class DeleteMultipleSupportSkillPopupViewModel : DataModel
    {
        public int                                      DeleteNum                               { get; set; }
        public List<int>?                               SelectedIndexList                       { get; set; }
        public List<IPotentialSupportSkillStatus>?      SkillList                               { get; set; }

        public static DeleteMultipleSupportSkillPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteMultipleSupportSkillPopupViewModel() { Pointer= p0 };

            value.DeleteNum                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 DeleteNum                   ( ModelPrimitiveType int int int Int32 )
            value.SelectedIndexList                         = GetInt32List(new IntPtr(p + 0x018)); // 0x18 SelectedIndexList           ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.SkillList                                 = GetObjectList<IPotentialSupportSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPotentialSupportSkillStatus.FromPointer); // 0x20 SkillList                   ( ModelClassListType IReadOnlyList`1<IPotentialSupportSkillStatus> IReadOnlyList`1<IPotentialSupportSkillStatus> List<IPotentialSupportSkillStatus> Pointer )

            return value;
        }
    }
}
