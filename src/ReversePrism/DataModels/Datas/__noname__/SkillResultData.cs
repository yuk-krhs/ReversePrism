using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Executor                                 0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 018 Opponent                                 0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 020 UseSkillData                             000186696450 ModelClassType SkillData SkillData SkillData Pointer
    public partial class SkillResultData : DataModel
    {
        public IngamePlayerModel?                       Executor                                { get; set; }
        public IngamePlayerModel?                       Opponent                                { get; set; }
        public SkillData?                               UseSkillData                            { get; set; }

        public static SkillResultData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillResultData() { Pointer= p0 };

            value.Executor                                  = GetObject<IngamePlayerModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 024665B028B0 0x10 Executor                    ( 0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.Opponent                                  = GetObject<IngamePlayerModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 024665B028D0 0x18 Opponent                    ( 0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.UseSkillData                              = GetObject<SkillData>(new IntPtr(p + 0x020), ReversePrism.DataModels.SkillData.FromPointer); // 024665B028F0 0x20 UseSkillData                ( 000186696450 ModelClassType SkillData SkillData SkillData Pointer )

            return value;
        }
    }
}
