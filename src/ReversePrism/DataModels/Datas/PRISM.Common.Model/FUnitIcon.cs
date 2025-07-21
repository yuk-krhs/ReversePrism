using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSelected                               ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 inTransferModeRP                         ReactiveProperty`1<ValueTuple`5<bool, bool, bool, bool, bool>> IL2CPP_TYPE_GENERICINST
    // 020 ChangeFavoriteInTransferModeRP           ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 028 GrayOutRP                                ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 030 FavoriteMarkIdRP                         ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 038 UnitNameRP                               ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer
    // 040 SelectedFavoriteIconId                   ModelPrimitiveType int int int Int32
    // 044 InFavoriteMode                           ModelPrimitiveType bool bool bool Bool
    // 045 IsSelectedLimit                          ModelPrimitiveType bool bool bool Bool
    // 048 FesUnitId                                ModelPrimitiveType string string string String
    // 050 UnitId                                   ModelPrimitiveType int int int Int32
    // 054 Rank                                     ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 058 Idols                                    ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 060 Parameter                                ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 068 InheritanceCount                         ModelPrimitiveType int int int Int32
    // 06C InheritedByProduce                       ModelPrimitiveType bool bool bool Bool
    // 06D InChallengeTour                          ModelPrimitiveType bool bool bool Bool
    // 06E InPvp                                    ModelPrimitiveType bool bool bool Bool
    // 070 CurrentOrderType                         ModelEnumType OrderType OrderType OrderType Int32
    // 078 CreateDate                               ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 080 TransferProductList                      ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    public partial class FUnitIcon : DataModel
    {
        public BoolReactiveProperty?                    OnSelected                              { get; set; }
        public IntReactiveProperty?                     ChangeFavoriteInTransferModeRP          { get; set; }
        public BoolReactiveProperty?                    GrayOutRP                               { get; set; }
        public IntReactiveProperty?                     FavoriteMarkIdRP                        { get; set; }
        public StringReactiveProperty?                  UnitNameRP                              { get; set; }
        public int                                      SelectedFavoriteIconId                  { get; set; }
        public bool                                     InFavoriteMode                          { get; set; }
        public bool                                     IsSelectedLimit                         { get; set; }
        public string                                   FesUnitId                               { get; set; }
        public int                                      UnitId                                  { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public List<int>?                               Idols                                   { get; set; }
        public IProduceParameterStatus?                 Parameter                               { get; set; }
        public int                                      InheritanceCount                        { get; set; }
        public bool                                     InheritedByProduce                      { get; set; }
        public bool                                     InChallengeTour                         { get; set; }
        public bool                                     InPvp                                   { get; set; }
        public OrderType                                CurrentOrderType                        { get; set; }
        public DateTime                                 CreateDate                              { get; set; }
        public List<IProductWithAmountStatus>?          TransferProductList                     { get; set; }

        public static FUnitIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitIcon() { Pointer= p0 };

            value.OnSelected                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 OnSelected                  ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.ChangeFavoriteInTransferModeRP            = GetObject<IntReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x20 ChangeFavoriteInTransferModeRP ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.GrayOutRP                                 = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x028), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x28 GrayOutRP                   ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.FavoriteMarkIdRP                          = GetObject<IntReactiveProperty>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x30 FavoriteMarkIdRP            ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.UnitNameRP                                = GetObject<StringReactiveProperty>(new IntPtr(p + 0x038), ReversePrism.DataModels.StringReactiveProperty.FromPointer); // 0x38 UnitNameRP                  ( ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer )
            value.SelectedFavoriteIconId                    = GetInt32(new IntPtr(p + 0x040)); // 0x40 SelectedFavoriteIconId      ( ModelPrimitiveType int int int Int32 )
            value.InFavoriteMode                            = GetBool(new IntPtr(p + 0x044)); // 0x44 InFavoriteMode              ( ModelPrimitiveType bool bool bool Bool )
            value.IsSelectedLimit                           = GetBool(new IntPtr(p + 0x045)); // 0x45 IsSelectedLimit             ( ModelPrimitiveType bool bool bool Bool )
            value.FesUnitId                                 = GetString(new IntPtr(p + 0x048)); // 0x48 FesUnitId                   ( ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x050)); // 0x50 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x054)); // 0x54 Rank                        ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Idols                                     = GetInt32List(new IntPtr(p + 0x058)); // 0x58 Idols                       ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.Parameter                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x60 Parameter                   ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.InheritanceCount                          = GetInt32(new IntPtr(p + 0x068)); // 0x68 InheritanceCount            ( ModelPrimitiveType int int int Int32 )
            value.InheritedByProduce                        = GetBool(new IntPtr(p + 0x06C)); // 0x6C InheritedByProduce          ( ModelPrimitiveType bool bool bool Bool )
            value.InChallengeTour                           = GetBool(new IntPtr(p + 0x06D)); // 0x6D InChallengeTour             ( ModelPrimitiveType bool bool bool Bool )
            value.InPvp                                     = GetBool(new IntPtr(p + 0x06E)); // 0x6E InPvp                       ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentOrderType                          = (OrderType)GetInt32(new IntPtr(p + 0x070)); // 0x70 CurrentOrderType            ( ModelEnumType OrderType OrderType OrderType Int32 )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x078)); // 0x78 CreateDate                  ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.TransferProductList                       = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x80 TransferProductList         ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
