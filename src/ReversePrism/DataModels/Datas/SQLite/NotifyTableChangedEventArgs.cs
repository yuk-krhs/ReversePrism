using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    0001866195E0 ModelClassType TableMapping TableMapping TableMapping Pointer
    // 018 Action                                   0001866B7A40 ModelEnumType NotifyTableChangedAction NotifyTableChangedAction NotifyTableChangedAction Int32
    public partial class NotifyTableChangedEventArgs : DataModel
    {
        public TableMapping?                            Table                                   { get; set; }
        public NotifyTableChangedAction                 Action                                  { get; set; }

        public static NotifyTableChangedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotifyTableChangedEventArgs() { Pointer= p0 };

            value.Table                                     = GetObject<TableMapping>(new IntPtr(p + 0x010), ReversePrism.DataModels.TableMapping.FromPointer); // 0245A44AD6C8 0x10 Table                       ( 0001866195E0 ModelClassType TableMapping TableMapping TableMapping Pointer )
            value.Action                                    = (NotifyTableChangedAction)GetInt32(new IntPtr(p + 0x018)); // 0245A44AD6E8 0x18 Action                      ( 0001866B7A40 ModelEnumType NotifyTableChangedAction NotifyTableChangedAction NotifyTableChangedAction Int32 )

            return value;
        }
    }
}
