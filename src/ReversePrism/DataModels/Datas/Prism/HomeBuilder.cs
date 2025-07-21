using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType HomeView HomeView HomeView Pointer
    // 028 SubFooterView                            ModelClassType HomeSubFooterPanelView HomeSubFooterPanelView HomeSubFooterPanelView Pointer
    // 030 MainView                                 ModelClassType HomeMainView HomeMainView HomeMainView Pointer
    // 038 MobileNotificationBuilder                ModelClassType MobileNotificationBuilder MobileNotificationBuilder MobileNotificationBuilder Pointer
    // 040 EventListButtonView                      ModelClassType EventListButtonView EventListButtonView EventListButtonView Pointer
    public partial class HomeBuilder : DataModel
    {
        public HomeView?                                View                                    { get; set; }
        public HomeSubFooterPanelView?                  SubFooterView                           { get; set; }
        public HomeMainView?                            MainView                                { get; set; }
        public MobileNotificationBuilder?               MobileNotificationBuilder               { get; set; }
        public EventListButtonView?                     EventListButtonView                     { get; set; }

        public static HomeBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBuilder() { Pointer= p0 };

            value.View                                      = GetObject<HomeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeView.FromPointer); // 0x20 View                        ( ModelClassType HomeView HomeView HomeView Pointer )
            value.SubFooterView                             = GetObject<HomeSubFooterPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeSubFooterPanelView.FromPointer); // 0x28 SubFooterView               ( ModelClassType HomeSubFooterPanelView HomeSubFooterPanelView HomeSubFooterPanelView Pointer )
            value.MainView                                  = GetObject<HomeMainView>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeMainView.FromPointer); // 0x30 MainView                    ( ModelClassType HomeMainView HomeMainView HomeMainView Pointer )
            value.MobileNotificationBuilder                 = GetObject<MobileNotificationBuilder>(new IntPtr(p + 0x038), ReversePrism.DataModels.MobileNotificationBuilder.FromPointer); // 0x38 MobileNotificationBuilder   ( ModelClassType MobileNotificationBuilder MobileNotificationBuilder MobileNotificationBuilder Pointer )
            value.EventListButtonView                       = GetObject<EventListButtonView>(new IntPtr(p + 0x040), ReversePrism.DataModels.EventListButtonView.FromPointer); // 0x40 EventListButtonView         ( ModelClassType EventListButtonView EventListButtonView EventListButtonView Pointer )

            return value;
        }
    }
}
