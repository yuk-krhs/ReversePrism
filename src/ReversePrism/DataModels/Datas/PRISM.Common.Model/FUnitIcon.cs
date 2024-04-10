using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSelected                               0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 inTransferModeRP                         ReactiveProperty`1<ValueTuple`5<bool, bool, bool, bool, bool>> IL2CPP_TYPE_GENERICINST
    // 020 ChangeFavoriteInTransferModeRP           000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 028 GrayOutRP                                0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 030 FavoriteMarkIdRP                         000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 038 UnitNameRP                               0001865C1960 ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer
    // 040 SelectedFavoriteIconId                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 InFavoriteMode                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 045 IsSelectedLimit                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 FesUnitId                                000186671910 ModelPrimitiveType string string string String
    // 050 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 Rank                                     00018660D900 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 058 Idols                                    000185D11E28 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 060 Parameter                                0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 068 InheritanceCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 06C InheritedByProduce                       0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 06D InChallengeTour                          0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 06E InPvp                                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 070 CurrentOrderType                         00018668A7E0 ModelEnumType OrderType OrderType OrderType Int32
    // 078 CreateDate                               0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 080 TransferProductList                      000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
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

            value.OnSelected                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 024664CEB8C0 0x10 OnSelected                  ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.ChangeFavoriteInTransferModeRP            = GetObject<IntReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 024664CEB900 0x20 ChangeFavoriteInTransferModeRP ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.GrayOutRP                                 = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x028), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 024664CEB920 0x28 GrayOutRP                   ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.FavoriteMarkIdRP                          = GetObject<IntReactiveProperty>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 024664CEB940 0x30 FavoriteMarkIdRP            ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.UnitNameRP                                = GetObject<StringReactiveProperty>(new IntPtr(p + 0x038), ReversePrism.DataModels.StringReactiveProperty.FromPointer); // 024664CEB960 0x38 UnitNameRP                  ( 0001865C1960 ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer )
            value.SelectedFavoriteIconId                    = GetInt32(new IntPtr(p + 0x040)); // 024664CEB980 0x40 SelectedFavoriteIconId      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InFavoriteMode                            = GetBool(new IntPtr(p + 0x044)); // 024664CEB9A0 0x44 InFavoriteMode              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSelectedLimit                           = GetBool(new IntPtr(p + 0x045)); // 024664CEB9C0 0x45 IsSelectedLimit             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FesUnitId                                 = GetString(new IntPtr(p + 0x048)); // 024664CEB9E0 0x48 FesUnitId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x050)); // 024664CEBA00 0x50 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x054)); // 024664CEBA20 0x54 Rank                        ( 00018660D900 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Idols                                     = GetInt32List(new IntPtr(p + 0x058)); // 024664CEBA40 0x58 Idols                       ( 000185D11E28 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.Parameter                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 024664CEBA60 0x60 Parameter                   ( 0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.InheritanceCount                          = GetInt32(new IntPtr(p + 0x068)); // 024664CEBA80 0x68 InheritanceCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InheritedByProduce                        = GetBool(new IntPtr(p + 0x06C)); // 024664CEBAA0 0x6C InheritedByProduce          ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.InChallengeTour                           = GetBool(new IntPtr(p + 0x06D)); // 024664CEBAC0 0x6D InChallengeTour             ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.InPvp                                     = GetBool(new IntPtr(p + 0x06E)); // 024664CEBAE0 0x6E InPvp                       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.CurrentOrderType                          = (OrderType)GetInt32(new IntPtr(p + 0x070)); // 024664CEBB00 0x70 CurrentOrderType            ( 00018668A7E0 ModelEnumType OrderType OrderType OrderType Int32 )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x078)); // 024664CEBB20 0x78 CreateDate                  ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.TransferProductList                       = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 024664CEBB40 0x80 TransferProductList         ( 000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
