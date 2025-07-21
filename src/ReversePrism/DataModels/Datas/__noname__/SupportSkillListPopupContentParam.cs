using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 SupportSkillList                         ModelClassListType IReadOnlyList`1<IPotentialSupportSkillStatus> IReadOnlyList`1<IPotentialSupportSkillStatus> List<IPotentialSupportSkillStatus> Pointer
    // 098 MaxSlotNum                               ModelPrimitiveType int int int Int32
    public partial class SupportSkillListPopupContentParam : DataModel
    {
        public List<IPotentialSupportSkillStatus>?      SupportSkillList                        { get; set; }
        public int                                      MaxSlotNum                              { get; set; }

        public static SupportSkillListPopupContentParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillListPopupContentParam() { Pointer= p0 };

            value.SupportSkillList                          = GetObjectList<IPotentialSupportSkillStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPotentialSupportSkillStatus.FromPointer); // 0x90 SupportSkillList            ( ModelClassListType IReadOnlyList`1<IPotentialSupportSkillStatus> IReadOnlyList`1<IPotentialSupportSkillStatus> List<IPotentialSupportSkillStatus> Pointer )
            value.MaxSlotNum                                = GetInt32(new IntPtr(p + 0x098)); // 0x98 MaxSlotNum                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
