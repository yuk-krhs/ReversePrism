using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TrainingExp                              ModelPrimitiveType long long long Int64
    // 018 IsMaxExpInTraining                       ModelPrimitiveType bool bool bool Bool
    // 020 isMaxLvRP                                ReactiveProperty`1<ValueTuple`2<bool, bool>> IL2CPP_TYPE_GENERICINST
    // 028 CurrentCharaLv                           ModelPrimitiveType int int int Int32
    // 030 CurrentExp                               ModelPrimitiveType long long long Int64
    // 038 Calculator                               ModelClassType CalcLvExp CalcLvExp CalcLvExp Pointer
    // 040 MoneyRP                                  ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 048 RequiredMoneyRP                          ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 050 CanResetRP                               ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 058 ShortageRP                               ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 060 CanExecuteTrainingRP                     ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 068 expStatusChangeRP                        ReactiveProperty`1<ValueTuple`4<int, long, long, float>> IL2CPP_TYPE_GENERICINST
    // 070 AcquiredSupportEffectContentIndexRP      ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 078 SupportEffectContents                    ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer
    // 080 TrainingTickets                          ModelClassListType TrainingTicketViewModel[] TrainingTicketViewModel[] List<TrainingTicketViewModel> Pointer
    // 088 <DecreaseTicket>k__BackingField          Subject`1<ValueTuple`3<int, int, bool>> IL2CPP_TYPE_GENERICINST
    // 090 <IncreaseTicket>k__BackingField          Subject`1<ValueTuple`4<int, int, bool, bool>> IL2CPP_TYPE_GENERICINST
    // 098 <UpdateTicket>k__BackingField            Subject`1<ValueTuple`3<int, long, bool>> IL2CPP_TYPE_GENERICINST
    // 0A0 <OnExecute>k__BackingField               Subject`1<IEnumerable`1<TrainingTicketViewModel>> IL2CPP_TYPE_GENERICINST
    public partial class SupportCharaTrainingViewModel : DataModel
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
            var value   = new SupportCharaTrainingViewModel() { Pointer= p0 };

            value.TrainingExp                               = GetInt64(new IntPtr(p + 0x010)); // 0x10 TrainingExp                 ( ModelPrimitiveType long long long Int64 )
            value.IsMaxExpInTraining                        = GetBool(new IntPtr(p + 0x018)); // 0x18 IsMaxExpInTraining          ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentCharaLv                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 CurrentCharaLv              ( ModelPrimitiveType int int int Int32 )
            value.CurrentExp                                = GetInt64(new IntPtr(p + 0x030)); // 0x30 CurrentExp                  ( ModelPrimitiveType long long long Int64 )
            value.Calculator                                = GetObject<CalcLvExp>(new IntPtr(p + 0x038), ReversePrism.DataModels.CalcLvExp.FromPointer); // 0x38 Calculator                  ( ModelClassType CalcLvExp CalcLvExp CalcLvExp Pointer )
            value.MoneyRP                                   = GetObject<LongReactiveProperty>(new IntPtr(p + 0x040), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 0x40 MoneyRP                     ( ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )
            value.RequiredMoneyRP                           = GetObject<IntReactiveProperty>(new IntPtr(p + 0x048), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x48 RequiredMoneyRP             ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.CanResetRP                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x050), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x50 CanResetRP                  ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.ShortageRP                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x058), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x58 ShortageRP                  ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.CanExecuteTrainingRP                      = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x060), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x60 CanExecuteTrainingRP        ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.AcquiredSupportEffectContentIndexRP       = GetObject<IntReactiveProperty>(new IntPtr(p + 0x070), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x70 AcquiredSupportEffectContentIndexRP ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.SupportEffectContents                     = GetObjectList<SupportEffectContentViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 0x78 SupportEffectContents       ( ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer )
            value.TrainingTickets                           = GetObjectList<TrainingTicketViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.TrainingTicketViewModel.FromPointer); // 0x80 TrainingTickets             ( ModelClassListType TrainingTicketViewModel[] TrainingTicketViewModel[] List<TrainingTicketViewModel> Pointer )

            return value;
        }
    }
}
