using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TicketSelectors                          ModelClassListType TicketSelectorView[] TicketSelectorView[] List<TicketSelectorView> Pointer
    // 028 Tickets                                  ModelClassListType TrainingTicketViewModel[] TrainingTicketViewModel[] List<TrainingTicketViewModel> Pointer
    // 030 GroupMaxExpRP                            ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 038 <OnButton>k__BackingField                IObservable`1<ValueTuple`2<int, TicketButtonType>> IL2CPP_TYPE_GENERICINST
    public partial class TicketSelectorViewGroup : DataModel
    {
        public List<TicketSelectorView>?                TicketSelectors                         { get; set; }
        public List<TrainingTicketViewModel>?           Tickets                                 { get; set; }
        public BoolReactiveProperty?                    GroupMaxExpRP                           { get; set; }

        public static TicketSelectorViewGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TicketSelectorViewGroup() { Pointer= p0 };

            value.TicketSelectors                           = GetObjectList<TicketSelectorView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TicketSelectorView.FromPointer); // 0x20 TicketSelectors             ( ModelClassListType TicketSelectorView[] TicketSelectorView[] List<TicketSelectorView> Pointer )
            value.Tickets                                   = GetObjectList<TrainingTicketViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.TrainingTicketViewModel.FromPointer); // 0x28 Tickets                     ( ModelClassListType TrainingTicketViewModel[] TrainingTicketViewModel[] List<TrainingTicketViewModel> Pointer )
            value.GroupMaxExpRP                             = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x030), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x30 GroupMaxExpRP               ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )

            return value;
        }
    }
}
