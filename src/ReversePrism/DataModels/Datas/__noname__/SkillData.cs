using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkillModel                               0001866E7FA0 ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer
    // 018 PcardModel                               0001866E49A0 ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer
    // 020 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class SkillData : DataModel
    {
        public IngameSkillModel?                        SkillModel                              { get; set; }
        public IngamePCardModel?                        PcardModel                              { get; set; }
        public int                                      Index                                   { get; set; }

        public static SkillData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillData() { Pointer= p0 };

            value.SkillModel                                = GetObject<IngameSkillModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 024665B00D40 0x10 SkillModel                  ( 0001866E7FA0 ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer )
            value.PcardModel                                = GetObject<IngamePCardModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 024665B00D60 0x18 PcardModel                  ( 0001866E49A0 ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 024665B00D80 0x20 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
