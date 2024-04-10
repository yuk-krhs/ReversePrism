using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NotificationManageViewModel              0001866B2CF0 ModelClassType NotificationManageViewModel NotificationManageViewModel NotificationManageViewModel Pointer
    public partial class GlobalMenuViewModel : DataModel
    {
        public NotificationManageViewModel?             NotificationManageViewModel             { get; set; }

        public static GlobalMenuViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalMenuViewModel() { Pointer= p0 };

            value.NotificationManageViewModel               = GetObject<NotificationManageViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.NotificationManageViewModel.FromPointer); // 0246663DA9E8 0x10 NotificationManageViewModel ( 0001866B2CF0 ModelClassType NotificationManageViewModel NotificationManageViewModel NotificationManageViewModel Pointer )

            return value;
        }
    }
}
