using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Popup                                    00018675FEB0 ModelClassType PopupBase PopupBase PopupBase Pointer
    // 018 Priority                                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class PopupInfo
    {
        public PopupBase?                               Popup                                   { get; set; }
        public int                                      Priority                                { get; set; }

        public static PopupInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PopupInfo();

            value.Popup                                     = GetObject<PopupBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.PopupBase.FromPointer); // 0270D0A54ED0 0x10 Popup                       ( 00018675FEB0 ModelClassType PopupBase PopupBase PopupBase Pointer )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D0A54EF0 0x18 Priority                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
