using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CmnTable                                 0001865BC990 ModelClassType CmnTable CmnTable CmnTable Pointer
    // 028 XmlPanel                                 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    public partial class GashaBonusRateView
    {
        public CmnTable?                                CmnTable                                { get; set; }
        public XMLPanel?                                XmlPanel                                { get; set; }

        public static GashaBonusRateView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaBonusRateView();

            value.CmnTable                                  = GetObject<CmnTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CmnTable.FromPointer); // 0270D52EF6F8 0x20 CmnTable                    ( 0001865BC990 ModelClassType CmnTable CmnTable CmnTable Pointer )
            value.XmlPanel                                  = GetObject<XMLPanel>(new IntPtr(p + 0x028), ReversePrism.DataModels.XMLPanel.FromPointer); // 0270D52EF718 0x28 XmlPanel                    ( 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer )

            return value;
        }
    }
}
