using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OffsetScore                              ModelPrimitiveType int int int Int32
    // 018 Executor                                 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 020 Opponent                                 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 028 UseSkillData                             ModelClassType SkillData SkillData SkillData Pointer
    public partial class SkillResultData : DataModel
    {
        public int                                      OffsetScore                             { get; set; }
        public IngamePlayerModel?                       Executor                                { get; set; }
        public IngamePlayerModel?                       Opponent                                { get; set; }
        public SkillData?                               UseSkillData                            { get; set; }

        public static SkillResultData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillResultData() { Pointer= p0 };

            value.OffsetScore                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 OffsetScore                 ( ModelPrimitiveType int int int Int32 )
            value.Executor                                  = GetObject<IngamePlayerModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x18 Executor                    ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.Opponent                                  = GetObject<IngamePlayerModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x20 Opponent                    ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.UseSkillData                              = GetObject<SkillData>(new IntPtr(p + 0x028), ReversePrism.DataModels.SkillData.FromPointer); // 0x28 UseSkillData                ( ModelClassType SkillData SkillData SkillData Pointer )

            return value;
        }
    }
}
