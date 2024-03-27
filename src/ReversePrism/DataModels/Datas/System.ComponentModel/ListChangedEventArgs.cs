using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ListChangedType                          000186537230 ModelEnumType ListChangedType ListChangedType ListChangedType Int32
    // 014 NewIndex                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 018 OldIndex                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 020 PropertyDescriptor                       0001865D3000 ModelClassType PropertyDescriptor PropertyDescriptor PropertyDescriptor Pointer
    public partial class ListChangedEventArgs
    {
        public ListChangedType                          ListChangedType                         { get; set; }
        public int                                      NewIndex                                { get; set; }
        public int                                      OldIndex                                { get; set; }
        public PropertyDescriptor?                      PropertyDescriptor                      { get; set; }

        public static ListChangedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListChangedEventArgs();

            value.ListChangedType                           = (ListChangedType)GetInt32(new IntPtr(p + 0x010)); // 0270D7B1FA80 0x10 ListChangedType             ( 000186537230 ModelEnumType ListChangedType ListChangedType ListChangedType Int32 )
            value.NewIndex                                  = GetInt32(new IntPtr(p + 0x014)); // 0270D7B1FAA0 0x14 NewIndex                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.OldIndex                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D7B1FAC0 0x18 OldIndex                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.PropertyDescriptor                        = GetObject<PropertyDescriptor>(new IntPtr(p + 0x020), ReversePrism.DataModels.PropertyDescriptor.FromPointer); // 0270D7B1FAE0 0x20 PropertyDescriptor          ( 0001865D3000 ModelClassType PropertyDescriptor PropertyDescriptor PropertyDescriptor Pointer )

            return value;
        }
    }
}
