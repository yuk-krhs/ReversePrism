using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TrainingExp                              0001865F7700 ModelPrimitiveType long long long Int64
    // 018 IsMaxExpInTraining                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 isMaxLvRP                                ReactiveProperty`1<ValueTuple`2<bool, bool>> IL2CPP_TYPE_GENERICINST
    // 028 CurrentCharaLv                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 CurrentExp                               0001865F7700 ModelPrimitiveType long long long Int64
    // 038 Calculator                               000186523FB0 ModelClassType CalcLvExp CalcLvExp CalcLvExp Pointer
    // 040 MoneyRP                                  0001865BF5C0 ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 048 RequiredMoneyRP                          000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 050 CanResetRP                               0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 058 ShortageRP                               0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 060 CanExecuteTrainingRP                     0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 068 expStatusChangeRP                        ReactiveProperty`1<ValueTuple`4<int, long, long, float>> IL2CPP_TYPE_GENERICINST
    // 070 AcquiredSupportEffectContentIndexRP      000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 078 SupportEffectContents                    000185D10A28 ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer
    // 080 TrainingTickets                          000185CACC28 ModelClassListType TrainingTicketViewModel[] TrainingTicketViewModel[] List<TrainingTicketViewModel> Pointer
    // 088 <DecreaseTicket>k__BackingField          Subject`1<ValueTuple`3<int, int, bool>> IL2CPP_TYPE_GENERICINST
    // 090 <IncreaseTicket>k__BackingField          Subject`1<ValueTuple`4<int, int, bool, bool>> IL2CPP_TYPE_GENERICINST
    // 098 <UpdateTicket>k__BackingField            Subject`1<ValueTuple`3<int, long, bool>> IL2CPP_TYPE_GENERICINST
    // 0A0 <OnExecute>k__BackingField               Subject`1<IEnumerable`1<TrainingTicketViewModel>> IL2CPP_TYPE_GENERICINST
    public partial class SupportCharaTrainingViewModel
    {
        public long                                     TrainingExp                             { get; set; }
        public bool                                     IsMaxExpInTraining                      { get; set; }
        public int                                      CurrentCharaLv                          { get; set; }
        public long                                     CurrentExp                              { get; set; }
        public CalcLvExp?                               Calculator                              { get; set; }
        public LongReactiveProperty?                    MoneyRP                                 { get; set; }
        public IntReactiveProperty?                     RequiredMoneyRP                         { get; set; }
        public BoolReactiveProperty?                    CanResetRP                              { get; set; }
        public BoolReactiveProperty?                    ShortageRP                              { get; set; }
        public BoolReactiveProperty?                    CanExecuteTrainingRP                    { get; set; }
        public IntReactiveProperty?                     AcquiredSupportEffectContentIndexRP     { get; set; }
        public List<SupportEffectContentViewModel>?     SupportEffectContents                   { get; set; }
        public List<TrainingTicketViewModel>?           TrainingTickets                         { get; set; }

        public static SupportCharaTrainingViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaTrainingViewModel();

            value.TrainingExp                               = GetInt64(new IntPtr(p + 0x010)); // 0270D605AF20 0x10 TrainingExp                 ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.IsMaxExpInTraining                        = GetBool(new IntPtr(p + 0x018)); // 0270D605AF40 0x18 IsMaxExpInTraining          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentCharaLv                            = GetInt32(new IntPtr(p + 0x028)); // 0270D605AF80 0x28 CurrentCharaLv              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentExp                                = GetInt64(new IntPtr(p + 0x030)); // 0270D605AFA0 0x30 CurrentExp                  ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Calculator                                = GetObject<CalcLvExp>(new IntPtr(p + 0x038), ReversePrism.DataModels.CalcLvExp.FromPointer); // 0270D605AFC0 0x38 Calculator                  ( 000186523FB0 ModelClassType CalcLvExp CalcLvExp CalcLvExp Pointer )
            value.MoneyRP                                   = GetObject<LongReactiveProperty>(new IntPtr(p + 0x040), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 0270D605AFE0 0x40 MoneyRP                     ( 0001865BF5C0 ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )
            value.RequiredMoneyRP                           = GetObject<IntReactiveProperty>(new IntPtr(p + 0x048), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0270D605B000 0x48 RequiredMoneyRP             ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.CanResetRP                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x050), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0270D605B020 0x50 CanResetRP                  ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.ShortageRP                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x058), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0270D605B040 0x58 ShortageRP                  ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.CanExecuteTrainingRP                      = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x060), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0270D605B060 0x60 CanExecuteTrainingRP        ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.AcquiredSupportEffectContentIndexRP       = GetObject<IntReactiveProperty>(new IntPtr(p + 0x070), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0270D605B0A0 0x70 AcquiredSupportEffectContentIndexRP ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.SupportEffectContents                     = GetObjectList<SupportEffectContentViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 0270D605B0C0 0x78 SupportEffectContents       ( 000185D10A28 ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer )
            value.TrainingTickets                           = GetObjectList<TrainingTicketViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.TrainingTicketViewModel.FromPointer); // 0270D605B0E0 0x80 TrainingTickets             ( 000185CACC28 ModelClassListType TrainingTicketViewModel[] TrainingTicketViewModel[] List<TrainingTicketViewModel> Pointer )

            return value;
        }
    }
}
