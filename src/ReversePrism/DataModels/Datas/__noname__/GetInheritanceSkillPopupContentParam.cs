using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 GettableSkillList                        000185CE6CA8 ModelClassListType List`1<IPotentialSupportSkillStatus> List`1<IPotentialSupportSkillStatus> List<IPotentialSupportSkillStatus> Pointer
    // 098 SupportSkillList                         000185CE54F8 ModelClassListType List`1<IInProducePotentialSupportSkillStatus> List`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer
    // 0A0 MaxSlotNum                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A8 OnCompleted                              000186679A00 ModelClassType Action Action Action Pointer
    public partial class GetInheritanceSkillPopupContentParam
    {
        public List<IPotentialSupportSkillStatus>?      GettableSkillList                       { get; set; }
        public List<IInProducePotentialSupportSkillStatus>? SupportSkillList                        { get; set; }
        public int                                      MaxSlotNum                              { get; set; }
        public Action?                                  OnCompleted                             { get; set; }

        public static GetInheritanceSkillPopupContentParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetInheritanceSkillPopupContentParam();

            value.GettableSkillList                         = GetObjectList<IPotentialSupportSkillStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPotentialSupportSkillStatus.FromPointer); // 0270D5CD5100 0x90 GettableSkillList           ( 000185CE6CA8 ModelClassListType List`1<IPotentialSupportSkillStatus> List`1<IPotentialSupportSkillStatus> List<IPotentialSupportSkillStatus> Pointer )
            value.SupportSkillList                          = GetObjectList<IInProducePotentialSupportSkillStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.IInProducePotentialSupportSkillStatus.FromPointer); // 0270D5CD5120 0x98 SupportSkillList            ( 000185CE54F8 ModelClassListType List`1<IInProducePotentialSupportSkillStatus> List`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer )
            value.MaxSlotNum                                = GetInt32(new IntPtr(p + 0x0A0)); // 0270D5CD5140 0xA0 MaxSlotNum                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OnCompleted                               = GetObject<Action>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Action.FromPointer); // 0270D5CD5160 0xA8 OnCompleted                 ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
