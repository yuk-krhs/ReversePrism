using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RemindItemListViewModels                 000185B85060 ModelClassListType HomeRemindItemListViewModel[] HomeRemindItemListViewModel[] List<HomeRemindItemListViewModel> Pointer
    public partial class HomeRemindItemViewModel
    {
        public List<HomeRemindItemListViewModel>?       RemindItemListViewModels                { get; set; }

        public static HomeRemindItemViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeRemindItemViewModel();

            value.RemindItemListViewModels                  = GetObjectList<HomeRemindItemListViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeRemindItemListViewModel.FromPointer); // 0270D3195860 0x10 RemindItemListViewModels    ( 000185B85060 ModelClassListType HomeRemindItemListViewModel[] HomeRemindItemListViewModel[] List<HomeRemindItemListViewModel> Pointer )

            return value;
        }
    }
}
