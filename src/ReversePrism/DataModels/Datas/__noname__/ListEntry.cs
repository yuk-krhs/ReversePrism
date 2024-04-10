using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Next                                     000186631CC0 ModelClassType ListEntry ListEntry ListEntry Pointer
    // 018 _key                                     <object> IL2CPP_TYPE_OBJECT
    // 020 Handler                                  0001866BAB20 ModelClassType Delegate Delegate Delegate Pointer
    public partial class ListEntry : DataModel
    {
        public ListEntry?                               Next                                    { get; set; }
        public Delegate?                                Handler                                 { get; set; }

        public static ListEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListEntry() { Pointer= p0 };

            value.Next                                      = GetObject<ListEntry>(new IntPtr(p + 0x010), ReversePrism.DataModels.ListEntry.FromPointer); // 024667B7C550 0x10 Next                        ( 000186631CC0 ModelClassType ListEntry ListEntry ListEntry Pointer )
            value.Handler                                   = GetObject<Delegate>(new IntPtr(p + 0x020), ReversePrism.DataModels.Delegate.FromPointer); // 024667B7C590 0x20 Handler                     ( 0001866BAB20 ModelClassType Delegate Delegate Delegate Pointer )

            return value;
        }
    }
}
