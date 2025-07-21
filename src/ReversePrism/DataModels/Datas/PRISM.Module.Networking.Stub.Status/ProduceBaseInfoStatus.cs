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
    // 018 SelectedEpisode                          ModelClassType SelectedEpisodeStatus SelectedEpisodeStatus SelectedEpisodeStatus Pointer
    // 000 TermFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Term                                     ModelClassType ProduceTermStatus ProduceTermStatus ProduceTermStatus Pointer
    // 000 ProduceUnitFieldNumber                   int IL2CPP_TYPE_I4
    // 028 ProduceUnit                              ModelClassType ProduceUnitStatus ProduceUnitStatus ProduceUnitStatus Pointer
    // 000 ProduceCardDeckFieldNumber               int IL2CPP_TYPE_I4
    // 030 ProduceCardDeck                          ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    // 000 NextOrderFieldNumber                     int IL2CPP_TYPE_I4
    // 038 NextOrder                                ModelClassType ProduceNextOrderStatus ProduceNextOrderStatus ProduceNextOrderStatus Pointer
    // 000 SupportUnitFieldNumber                   int IL2CPP_TYPE_I4
    // 040 SupportUnit                              ModelClassType SupportUnitStatus SupportUnitStatus SupportUnitStatus Pointer
    // 000 SelectedProduceStrategyListFieldNumber   int IL2CPP_TYPE_I4
    // 008 _repeated_selectedProduceStrategyList_codec FieldCodec`1<ProduceStrategyStatus> IL2CPP_TYPE_GENERICINST
    // 048 SelectedProduceStrategyList              ModelClassListType RepeatedField`1<ProduceStrategyStatus> RepeatedField`1<ProduceStrategyStatus> List<ProduceStrategyStatus> Pointer
    // 000 CurrentFanFieldNumber                    int IL2CPP_TYPE_I4
    // 050 CurrentFan                               ModelPrimitiveType int int int Int32
    // 000 SubSeasonFieldNumber                     int IL2CPP_TYPE_I4
    // 058 SubSeason                                ModelClassType SubSeasonStatus SubSeasonStatus SubSeasonStatus Pointer
    // 000 InheritanceFesUnitFieldNumber            int IL2CPP_TYPE_I4
    // 060 InheritanceFesUnit                       ModelClassType InheritanceFesUnitStatus InheritanceFesUnitStatus InheritanceFesUnitStatus Pointer
    // 000 IsAutoPlayFieldNumber                    int IL2CPP_TYPE_I4
    // 068 IsAutoPlay                               ModelPrimitiveType bool bool bool Bool
    public partial class ProduceBaseInfoStatus : DataModel
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
            var value   = new ProduceBaseInfoStatus() { Pointer= p0 };

            value.SelectedEpisode                           = GetObject<SelectedEpisodeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SelectedEpisodeStatus.FromPointer); // 0x18 SelectedEpisode             ( ModelClassType SelectedEpisodeStatus SelectedEpisodeStatus SelectedEpisodeStatus Pointer )
            value.Term                                      = GetObject<ProduceTermStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceTermStatus.FromPointer); // 0x20 Term                        ( ModelClassType ProduceTermStatus ProduceTermStatus ProduceTermStatus Pointer )
            value.ProduceUnit                               = GetObject<ProduceUnitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceUnitStatus.FromPointer); // 0x28 ProduceUnit                 ( ModelClassType ProduceUnitStatus ProduceUnitStatus ProduceUnitStatus Pointer )
            value.ProduceCardDeck                           = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0x30 ProduceCardDeck             ( ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )
            value.NextOrder                                 = GetObject<ProduceNextOrderStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceNextOrderStatus.FromPointer); // 0x38 NextOrder                   ( ModelClassType ProduceNextOrderStatus ProduceNextOrderStatus ProduceNextOrderStatus Pointer )
            value.SupportUnit                               = GetObject<SupportUnitStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportUnitStatus.FromPointer); // 0x40 SupportUnit                 ( ModelClassType SupportUnitStatus SupportUnitStatus SupportUnitStatus Pointer )
            value.SelectedProduceStrategyList               = GetObjectList<ProduceStrategyStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceStrategyStatus.FromPointer); // 0x48 SelectedProduceStrategyList ( ModelClassListType RepeatedField`1<ProduceStrategyStatus> RepeatedField`1<ProduceStrategyStatus> List<ProduceStrategyStatus> Pointer )
            value.CurrentFan                                = GetInt32(new IntPtr(p + 0x050)); // 0x50 CurrentFan                  ( ModelPrimitiveType int int int Int32 )
            value.SubSeason                                 = GetObject<SubSeasonStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.SubSeasonStatus.FromPointer); // 0x58 SubSeason                   ( ModelClassType SubSeasonStatus SubSeasonStatus SubSeasonStatus Pointer )
            value.InheritanceFesUnit                        = GetObject<InheritanceFesUnitStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.InheritanceFesUnitStatus.FromPointer); // 0x60 InheritanceFesUnit          ( ModelClassType InheritanceFesUnitStatus InheritanceFesUnitStatus InheritanceFesUnitStatus Pointer )
            value.IsAutoPlay                                = GetBool(new IntPtr(p + 0x068)); // 0x68 IsAutoPlay                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
