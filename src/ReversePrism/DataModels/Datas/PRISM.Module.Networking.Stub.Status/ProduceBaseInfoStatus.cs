using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceBaseInfoStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectedEpisodeFieldNumber               int IL2CPP_TYPE_I4
    // 018 SelectedEpisode                          000186720370 ModelClassType SelectedEpisodeStatus SelectedEpisodeStatus SelectedEpisodeStatus Pointer
    // 000 TermFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Term                                     000186589270 ModelClassType ProduceTermStatus ProduceTermStatus ProduceTermStatus Pointer
    // 000 ProduceUnitFieldNumber                   int IL2CPP_TYPE_I4
    // 028 ProduceUnit                              00018659C2D0 ModelClassType ProduceUnitStatus ProduceUnitStatus ProduceUnitStatus Pointer
    // 000 ProduceCardDeckFieldNumber               int IL2CPP_TYPE_I4
    // 030 ProduceCardDeck                          000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    // 000 NextOrderFieldNumber                     int IL2CPP_TYPE_I4
    // 038 NextOrder                                00018655F880 ModelClassType ProduceNextOrderStatus ProduceNextOrderStatus ProduceNextOrderStatus Pointer
    // 000 SupportUnitFieldNumber                   int IL2CPP_TYPE_I4
    // 040 SupportUnit                              0001865F8540 ModelClassType SupportUnitStatus SupportUnitStatus SupportUnitStatus Pointer
    // 000 SelectedProduceStrategyListFieldNumber   int IL2CPP_TYPE_I4
    // 008 _repeated_selectedProduceStrategyList_codec FieldCodec`1<ProduceStrategyStatus> IL2CPP_TYPE_GENERICINST
    // 048 SelectedProduceStrategyList              000185CEC478 ModelClassListType RepeatedField`1<ProduceStrategyStatus> RepeatedField`1<ProduceStrategyStatus> List<ProduceStrategyStatus> Pointer
    // 000 CurrentFanFieldNumber                    int IL2CPP_TYPE_I4
    // 050 CurrentFan                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SubSeasonFieldNumber                     int IL2CPP_TYPE_I4
    // 058 SubSeason                                0001865D7FC0 ModelClassType SubSeasonStatus SubSeasonStatus SubSeasonStatus Pointer
    // 000 InheritanceFesUnitFieldNumber            int IL2CPP_TYPE_I4
    // 060 InheritanceFesUnit                       0001866ED970 ModelClassType InheritanceFesUnitStatus InheritanceFesUnitStatus InheritanceFesUnitStatus Pointer
    // 000 IsAutoPlayFieldNumber                    int IL2CPP_TYPE_I4
    // 068 IsAutoPlay                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceBaseInfoStatus
    {
        public SelectedEpisodeStatus?                   SelectedEpisode                         { get; set; }
        public ProduceTermStatus?                       Term                                    { get; set; }
        public ProduceUnitStatus?                       ProduceUnit                             { get; set; }
        public ProduceCardDeckStatus?                   ProduceCardDeck                         { get; set; }
        public ProduceNextOrderStatus?                  NextOrder                               { get; set; }
        public SupportUnitStatus?                       SupportUnit                             { get; set; }
        public List<ProduceStrategyStatus>?             SelectedProduceStrategyList             { get; set; }
        public int                                      CurrentFan                              { get; set; }
        public SubSeasonStatus?                         SubSeason                               { get; set; }
        public InheritanceFesUnitStatus?                InheritanceFesUnit                      { get; set; }
        public bool                                     IsAutoPlay                              { get; set; }

        public static ProduceBaseInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceBaseInfoStatus();

            value.SelectedEpisode                           = GetObject<SelectedEpisodeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SelectedEpisodeStatus.FromPointer); // 0270D110D9E8 0x18 SelectedEpisode             ( 000186720370 ModelClassType SelectedEpisodeStatus SelectedEpisodeStatus SelectedEpisodeStatus Pointer )
            value.Term                                      = GetObject<ProduceTermStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceTermStatus.FromPointer); // 0270D110DA28 0x20 Term                        ( 000186589270 ModelClassType ProduceTermStatus ProduceTermStatus ProduceTermStatus Pointer )
            value.ProduceUnit                               = GetObject<ProduceUnitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceUnitStatus.FromPointer); // 0270D110DA68 0x28 ProduceUnit                 ( 00018659C2D0 ModelClassType ProduceUnitStatus ProduceUnitStatus ProduceUnitStatus Pointer )
            value.ProduceCardDeck                           = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0270D110DAA8 0x30 ProduceCardDeck             ( 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )
            value.NextOrder                                 = GetObject<ProduceNextOrderStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceNextOrderStatus.FromPointer); // 0270D110DAE8 0x38 NextOrder                   ( 00018655F880 ModelClassType ProduceNextOrderStatus ProduceNextOrderStatus ProduceNextOrderStatus Pointer )
            value.SupportUnit                               = GetObject<SupportUnitStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportUnitStatus.FromPointer); // 0270D110DB28 0x40 SupportUnit                 ( 0001865F8540 ModelClassType SupportUnitStatus SupportUnitStatus SupportUnitStatus Pointer )
            value.SelectedProduceStrategyList               = GetObjectList<ProduceStrategyStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceStrategyStatus.FromPointer); // 0270D110DB88 0x48 SelectedProduceStrategyList ( 000185CEC478 ModelClassListType RepeatedField`1<ProduceStrategyStatus> RepeatedField`1<ProduceStrategyStatus> List<ProduceStrategyStatus> Pointer )
            value.CurrentFan                                = GetInt32(new IntPtr(p + 0x050)); // 0270D110DBC8 0x50 CurrentFan                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SubSeason                                 = GetObject<SubSeasonStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.SubSeasonStatus.FromPointer); // 0270D110DC08 0x58 SubSeason                   ( 0001865D7FC0 ModelClassType SubSeasonStatus SubSeasonStatus SubSeasonStatus Pointer )
            value.InheritanceFesUnit                        = GetObject<InheritanceFesUnitStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.InheritanceFesUnitStatus.FromPointer); // 0270D110DC48 0x60 InheritanceFesUnit          ( 0001866ED970 ModelClassType InheritanceFesUnitStatus InheritanceFesUnitStatus InheritanceFesUnitStatus Pointer )
            value.IsAutoPlay                                = GetBool(new IntPtr(p + 0x068)); // 0270D110DC88 0x68 IsAutoPlay                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
