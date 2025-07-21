using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ListChangedType                          ModelEnumType ListChangedType ListChangedType ListChangedType Int32
    // 014 NewIndex                                 ModelPrimitiveType int int int Int32
    // 018 OldIndex                                 ModelPrimitiveType int int int Int32
    // 020 PropertyDescriptor                       ModelClassType PropertyDescriptor PropertyDescriptor PropertyDescriptor Pointer
    public partial class ListChangedEventArgs : DataModel
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
            var value   = new ListChangedEventArgs() { Pointer= p0 };

            value.ListChangedType                           = (ListChangedType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ListChangedType             ( ModelEnumType ListChangedType ListChangedType ListChangedType Int32 )
            value.NewIndex                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 NewIndex                    ( ModelPrimitiveType int int int Int32 )
            value.OldIndex                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 OldIndex                    ( ModelPrimitiveType int int int Int32 )
            value.PropertyDescriptor                        = GetObject<PropertyDescriptor>(new IntPtr(p + 0x020), ReversePrism.DataModels.PropertyDescriptor.FromPointer); // 0x20 PropertyDescriptor          ( ModelClassType PropertyDescriptor PropertyDescriptor PropertyDescriptor Pointer )

            return value;
        }
    }
}
