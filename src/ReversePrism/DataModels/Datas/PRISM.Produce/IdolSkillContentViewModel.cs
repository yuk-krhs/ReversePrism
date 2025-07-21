using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   ModelPrimitiveType int int int Int32
    // 018 IdolSkill                                ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer
    // 020 IconID                                   ModelPrimitiveType int int int Int32
    public partial class IdolSkillContentViewModel : DataModel
    {
        public int                                      UnitID                                  { get; set; }
        public IngameSkillModel?                        IdolSkill                               { get; set; }
        public int                                      IconID                                  { get; set; }

        public static IdolSkillContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillContentViewModel() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.IdolSkill                                 = GetObject<IngameSkillModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 0x18 IdolSkill                   ( ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer )
            value.IconID                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 IconID                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
