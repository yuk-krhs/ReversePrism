using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstSupportSkillTypeId                    ModelPrimitiveType int int int Int32
    // 018 ValueList                                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 MstSkillBufferDisplayId                  ModelPrimitiveType int int int Int32
    // 024 GrantMstSkillBufferDisplayId             ModelPrimitiveType int int int Int32
    // 028 EntrustAppealType                        ModelPrimitiveType int int int Int32
    // 02C EntrustScore                             ModelPrimitiveType int int int Int32
    public partial class MstPotentialSupportSkill : DataModel
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
            var value   = new MstPotentialSupportSkill() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstSupportSkillTypeId                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstSupportSkillTypeId       ( ModelPrimitiveType int int int Int32 )
            value.ValueList                                 = GetInt32List(new IntPtr(p + 0x018)); // 0x18 ValueList                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MstSkillBufferDisplayId                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstSkillBufferDisplayId     ( ModelPrimitiveType int int int Int32 )
            value.GrantMstSkillBufferDisplayId              = GetInt32(new IntPtr(p + 0x024)); // 0x24 GrantMstSkillBufferDisplayId ( ModelPrimitiveType int int int Int32 )
            value.EntrustAppealType                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 EntrustAppealType           ( ModelPrimitiveType int int int Int32 )
            value.EntrustScore                              = GetInt32(new IntPtr(p + 0x02C)); // 0x2C EntrustScore                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
