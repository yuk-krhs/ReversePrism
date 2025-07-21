using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Popup                                    ModelClassType PopupBase PopupBase PopupBase Pointer
    // 018 Priority                                 ModelPrimitiveType int int int Int32
    public partial class PopupInfo : DataModel
    {
        public PopupBase?                               Popup                                   { get; set; }
        public int                                      Priority                                { get; set; }

        public static PopupInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PopupInfo() { Pointer= p0 };

            value.Popup                                     = GetObject<PopupBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.PopupBase.FromPointer); // 0x10 Popup                       ( ModelClassType PopupBase PopupBase PopupBase Pointer )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 Priority                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
