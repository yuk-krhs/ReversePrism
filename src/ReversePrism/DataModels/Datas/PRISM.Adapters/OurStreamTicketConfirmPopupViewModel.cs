using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TicketMstId                              int IL2CPP_TYPE_I4
    // 010 IsLive                                   ModelPrimitiveType bool bool bool Bool
    // 011 EnableYoutubeButton                      ModelPrimitiveType bool bool bool Bool
    // 018 Ticket                                   ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    public partial class OurStreamTicketConfirmPopupViewModel : DataModel
    {
        public bool                                     IsLive                                  { get; set; }
        public bool                                     EnableYoutubeButton                     { get; set; }
        public IHavingProductStatus?                    Ticket                                  { get; set; }

        public static OurStreamTicketConfirmPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamTicketConfirmPopupViewModel() { Pointer= p0 };

            value.IsLive                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 IsLive                      ( ModelPrimitiveType bool bool bool Bool )
            value.EnableYoutubeButton                       = GetBool(new IntPtr(p + 0x011)); // 0x11 EnableYoutubeButton         ( ModelPrimitiveType bool bool bool Bool )
            value.Ticket                                    = GetObject<IHavingProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0x18 Ticket                      ( ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )

            return value;
        }
    }
}
