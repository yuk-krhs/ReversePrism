using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParameterTypes                           ModelEnumListType List`1<ProduceParameterType> List`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 018 Executor                                 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 020 Opponent                                 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 028 CardCostType                             ModelEnumType CostType CostType CostType Int32
    // 02C IsDoubleCard                             ModelPrimitiveType bool bool bool Bool
    // 030 CardRank                                 ModelPrimitiveType int int int Int32
    // 034 IsExclusion                              ModelPrimitiveType bool bool bool Bool
    // 035 IsIdolSkill                              ModelPrimitiveType bool bool bool Bool
    // 036 IsUseParameterType                       ModelPrimitiveType bool bool bool Bool
    public partial class AppealEffectConditionParam : DataModel
    {
        public List<ProduceParameterType>?              ParameterTypes                          { get; set; }
        public IngamePlayerModel?                       Executor                                { get; set; }
        public IngamePlayerModel?                       Opponent                                { get; set; }
        public CostType                                 CardCostType                            { get; set; }
        public bool                                     IsDoubleCard                            { get; set; }
        public int                                      CardRank                                { get; set; }
        public bool                                     IsExclusion                             { get; set; }
        public bool                                     IsIdolSkill                             { get; set; }
        public bool                                     IsUseParameterType                      { get; set; }

        public static AppealEffectConditionParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppealEffectConditionParam() { Pointer= p0 };

            value.ParameterTypes                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x010)); // 0x10 ParameterTypes              ( ModelEnumListType List`1<ProduceParameterType> List`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.Executor                                  = GetObject<IngamePlayerModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x18 Executor                    ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.Opponent                                  = GetObject<IngamePlayerModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x20 Opponent                    ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.CardCostType                              = (CostType)GetInt32(new IntPtr(p + 0x028)); // 0x28 CardCostType                ( ModelEnumType CostType CostType CostType Int32 )
            value.IsDoubleCard                              = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsDoubleCard                ( ModelPrimitiveType bool bool bool Bool )
            value.CardRank                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 CardRank                    ( ModelPrimitiveType int int int Int32 )
            value.IsExclusion                               = GetBool(new IntPtr(p + 0x034)); // 0x34 IsExclusion                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsIdolSkill                               = GetBool(new IntPtr(p + 0x035)); // 0x35 IsIdolSkill                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsUseParameterType                        = GetBool(new IntPtr(p + 0x036)); // 0x36 IsUseParameterType          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
