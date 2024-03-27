using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstSupportSkillTypeId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ValueList                                000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 MstSkillBufferDisplayId                  0001865F4260 ModelPrimitiveType int int int Int32
    // 024 GrantMstSkillBufferDisplayId             0001865F4260 ModelPrimitiveType int int int Int32
    // 028 EntrustAppealType                        0001865F4260 ModelPrimitiveType int int int Int32
    // 02C EntrustScore                             0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstPotentialSupportSkill
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstSupportSkillTypeId                   { get; set; }
        public List<int>?                               ValueList                               { get; set; }
        public int                                      MstSkillBufferDisplayId                 { get; set; }
        public int                                      GrantMstSkillBufferDisplayId            { get; set; }
        public int                                      EntrustAppealType                       { get; set; }
        public int                                      EntrustScore                            { get; set; }

        public static MstPotentialSupportSkill? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstPotentialSupportSkill();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270046104F8 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSupportSkillTypeId                     = GetInt32(new IntPtr(p + 0x014)); // 027004610518 0x14 MstSupportSkillTypeId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ValueList                                 = GetInt32List(new IntPtr(p + 0x018)); // 027004610538 0x18 ValueList                   ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MstSkillBufferDisplayId                   = GetInt32(new IntPtr(p + 0x020)); // 027004610558 0x20 MstSkillBufferDisplayId     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.GrantMstSkillBufferDisplayId              = GetInt32(new IntPtr(p + 0x024)); // 027004610578 0x24 GrantMstSkillBufferDisplayId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EntrustAppealType                         = GetInt32(new IntPtr(p + 0x028)); // 027004610598 0x28 EntrustAppealType           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EntrustScore                              = GetInt32(new IntPtr(p + 0x02C)); // 0270046105B8 0x2C EntrustScore                ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
