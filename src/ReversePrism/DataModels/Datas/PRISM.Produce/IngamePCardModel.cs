using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultPhase                             int IL2CPP_TYPE_I4
    // 010 ProduceCard                              0001865E4D60 ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer
    // 018 UniqueId                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 020 IngamePCardCardContentModels             000185CEBAD8 ModelClassListType List`1<IngamePCardContentModel> List`1<IngamePCardContentModel> List<IngamePCardContentModel> Pointer
    // 028 CurrentContent                           0001866E44D0 ModelClassType IngamePCardContentModel IngamePCardContentModel IngamePCardContentModel Pointer
    // 030 PhaseCharaNames                          000185D17078 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    // 038 IsCostOverWrite                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C OverWriteCost                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 IsRankOverWrite                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 OverWriteRank                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 Phase                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C HandCardPhaseChangeCount                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 BaseRank                                 0001865F4940 ModelPrimitiveType int int int Int32
    public partial class IngamePCardModel
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
        public int                                      BaseRank                                { get; set; }

        public static IngamePCardModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngamePCardModel();

            value.ProduceCard                               = GetObject<IProduceCardStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D59C1EA8 0x10 ProduceCard                 ( 0001865E4D60 ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer )
            value.UniqueId                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D59C1EC8 0x18 UniqueId                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IngamePCardCardContentModels              = GetObjectList<IngamePCardContentModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngamePCardContentModel.FromPointer); // 0270D59C1EE8 0x20 IngamePCardCardContentModels ( 000185CEBAD8 ModelClassListType List`1<IngamePCardContentModel> List`1<IngamePCardContentModel> List<IngamePCardContentModel> Pointer )
            value.CurrentContent                            = GetObject<IngamePCardContentModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.IngamePCardContentModel.FromPointer); // 0270D59C1F08 0x28 CurrentContent              ( 0001866E44D0 ModelClassType IngamePCardContentModel IngamePCardContentModel IngamePCardContentModel Pointer )
            value.PhaseCharaNames                           = GetStringList(new IntPtr(p + 0x030)); // 0270D59C1F28 0x30 PhaseCharaNames             ( 000185D17078 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )
            value.IsCostOverWrite                           = GetBool(new IntPtr(p + 0x038)); // 0270D59C1F48 0x38 IsCostOverWrite             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverWriteCost                             = GetInt32(new IntPtr(p + 0x03C)); // 0270D59C1F68 0x3C OverWriteCost               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsRankOverWrite                           = GetBool(new IntPtr(p + 0x040)); // 0270D59C1F88 0x40 IsRankOverWrite             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverWriteRank                             = GetInt32(new IntPtr(p + 0x044)); // 0270D59C1FA8 0x44 OverWriteRank               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Phase                                     = GetInt32(new IntPtr(p + 0x048)); // 0270D59C1FC8 0x48 Phase                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HandCardPhaseChangeCount                  = GetInt32(new IntPtr(p + 0x04C)); // 0270D59C1FE8 0x4C HandCardPhaseChangeCount    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseRank                                  = GetInt32(new IntPtr(p + 0x050)); // 0270D59C2008 0x50 BaseRank                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
