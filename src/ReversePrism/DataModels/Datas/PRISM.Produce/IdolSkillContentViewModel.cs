using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 018 IdolSkill                                0001866E8430 ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer
    // 020 IconID                                   0001865F4940 ModelPrimitiveType int int int Int32
    public partial class IdolSkillContentViewModel
    {
        public int                                      UnitID                                  { get; set; }
        public IngameSkillModel?                        IdolSkill                               { get; set; }
        public int                                      IconID                                  { get; set; }

        public static IdolSkillContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillContentViewModel();

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D59D7788 0x10 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.IdolSkill                                 = GetObject<IngameSkillModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 0270D59D77A8 0x18 IdolSkill                   ( 0001866E8430 ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer )
            value.IconID                                    = GetInt32(new IntPtr(p + 0x020)); // 0270D59D77C8 0x20 IconID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
