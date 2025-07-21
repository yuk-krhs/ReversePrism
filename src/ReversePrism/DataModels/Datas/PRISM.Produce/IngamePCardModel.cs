using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultPhase                             int IL2CPP_TYPE_I4
    // 010 ProduceCard                              ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer
    // 018 UniqueId                                 ModelPrimitiveType int int int Int32
    // 020 IngamePCardCardContentModels             ModelClassListType List`1<IngamePCardContentModel> List`1<IngamePCardContentModel> List<IngamePCardContentModel> Pointer
    // 028 CurrentContent                           ModelClassType IngamePCardContentModel IngamePCardContentModel IngamePCardContentModel Pointer
    // 030 PhaseCharaNames                          ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    // 038 IsCostOverWrite                          ModelPrimitiveType bool bool bool Bool
    // 03C OverWriteCost                            ModelPrimitiveType int int int Int32
    // 040 IsRankOverWrite                          ModelPrimitiveType bool bool bool Bool
    // 044 OverWriteRank                            ModelPrimitiveType int int int Int32
    // 048 Phase                                    ModelPrimitiveType int int int Int32
    // 04C HandCardPhaseChangeCount                 ModelPrimitiveType int int int Int32
    // 050 UseCount                                 ModelPrimitiveType int int int Int32
    // 054 BaseRank                                 ModelPrimitiveType int int int Int32
    // 058 IsPravCardAvailable                      ModelPrimitiveType bool bool bool Bool
    // 05C PravCardBuffDebuffState                  ModelEnumType BuffStatus BuffStatus BuffStatus Int32
    public partial class IngamePCardModel : DataModel
    {
        public IProduceCardStatus?                      ProduceCard                             { get; set; }
        public int                                      UniqueId                                { get; set; }
        public List<IngamePCardContentModel>?           IngamePCardCardContentModels            { get; set; }
        public IngamePCardContentModel?                 CurrentContent                          { get; set; }
        public List<string>?                            PhaseCharaNames                         { get; set; }
        public bool                                     IsCostOverWrite                         { get; set; }
        public int                                      OverWriteCost                           { get; set; }
        public bool                                     IsRankOverWrite                         { get; set; }
        public int                                      OverWriteRank                           { get; set; }
        public int                                      Phase                                   { get; set; }
        public int                                      HandCardPhaseChangeCount                { get; set; }
        public int                                      UseCount                                { get; set; }
        public int                                      BaseRank                                { get; set; }
        public bool                                     IsPravCardAvailable                     { get; set; }
        public BuffStatus                               PravCardBuffDebuffState                 { get; set; }

        public static IngamePCardModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngamePCardModel() { Pointer= p0 };

            value.ProduceCard                               = GetObject<IProduceCardStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x10 ProduceCard                 ( ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer )
            value.UniqueId                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 UniqueId                    ( ModelPrimitiveType int int int Int32 )
            value.IngamePCardCardContentModels              = GetObjectList<IngamePCardContentModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngamePCardContentModel.FromPointer); // 0x20 IngamePCardCardContentModels ( ModelClassListType List`1<IngamePCardContentModel> List`1<IngamePCardContentModel> List<IngamePCardContentModel> Pointer )
            value.CurrentContent                            = GetObject<IngamePCardContentModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.IngamePCardContentModel.FromPointer); // 0x28 CurrentContent              ( ModelClassType IngamePCardContentModel IngamePCardContentModel IngamePCardContentModel Pointer )
            value.PhaseCharaNames                           = GetStringList(new IntPtr(p + 0x030)); // 0x30 PhaseCharaNames             ( ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )
            value.IsCostOverWrite                           = GetBool(new IntPtr(p + 0x038)); // 0x38 IsCostOverWrite             ( ModelPrimitiveType bool bool bool Bool )
            value.OverWriteCost                             = GetInt32(new IntPtr(p + 0x03C)); // 0x3C OverWriteCost               ( ModelPrimitiveType int int int Int32 )
            value.IsRankOverWrite                           = GetBool(new IntPtr(p + 0x040)); // 0x40 IsRankOverWrite             ( ModelPrimitiveType bool bool bool Bool )
            value.OverWriteRank                             = GetInt32(new IntPtr(p + 0x044)); // 0x44 OverWriteRank               ( ModelPrimitiveType int int int Int32 )
            value.Phase                                     = GetInt32(new IntPtr(p + 0x048)); // 0x48 Phase                       ( ModelPrimitiveType int int int Int32 )
            value.HandCardPhaseChangeCount                  = GetInt32(new IntPtr(p + 0x04C)); // 0x4C HandCardPhaseChangeCount    ( ModelPrimitiveType int int int Int32 )
            value.UseCount                                  = GetInt32(new IntPtr(p + 0x050)); // 0x50 UseCount                    ( ModelPrimitiveType int int int Int32 )
            value.BaseRank                                  = GetInt32(new IntPtr(p + 0x054)); // 0x54 BaseRank                    ( ModelPrimitiveType int int int Int32 )
            value.IsPravCardAvailable                       = GetBool(new IntPtr(p + 0x058)); // 0x58 IsPravCardAvailable         ( ModelPrimitiveType bool bool bool Bool )
            value.PravCardBuffDebuffState                   = (BuffStatus)GetInt32(new IntPtr(p + 0x05C)); // 0x5C PravCardBuffDebuffState     ( ModelEnumType BuffStatus BuffStatus BuffStatus Int32 )

            return value;
        }
    }
}
