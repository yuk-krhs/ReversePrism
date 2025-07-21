using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Action                                   ModelEnumType NotifyCollectionChangedAction NotifyCollectionChangedAction NotifyCollectionChangedAction Int32
    // 018 NewItems                                 ModelClassType IList IList IList Pointer
    // 020 OldItems                                 ModelClassType IList IList IList Pointer
    // 028 NewStartingIndex                         ModelPrimitiveType int int int Int32
    // 02C OldStartingIndex                         ModelPrimitiveType int int int Int32
    public partial class NotifyCollectionChangedEventArgs : DataModel
    {
        public NotifyCollectionChangedAction            Action                                  { get; set; }
        public IList?                                   NewItems                                { get; set; }
        public IList?                                   OldItems                                { get; set; }
        public int                                      NewStartingIndex                        { get; set; }
        public int                                      OldStartingIndex                        { get; set; }

        public static NotifyCollectionChangedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotifyCollectionChangedEventArgs() { Pointer= p0 };

            value.Action                                    = (NotifyCollectionChangedAction)GetInt32(new IntPtr(p + 0x010)); // 0x10 Action                      ( ModelEnumType NotifyCollectionChangedAction NotifyCollectionChangedAction NotifyCollectionChangedAction Int32 )
            value.NewItems                                  = GetObject<IList>(new IntPtr(p + 0x018), ReversePrism.DataModels.IList.FromPointer); // 0x18 NewItems                    ( ModelClassType IList IList IList Pointer )
            value.OldItems                                  = GetObject<IList>(new IntPtr(p + 0x020), ReversePrism.DataModels.IList.FromPointer); // 0x20 OldItems                    ( ModelClassType IList IList IList Pointer )
            value.NewStartingIndex                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 NewStartingIndex            ( ModelPrimitiveType int int int Int32 )
            value.OldStartingIndex                          = GetInt32(new IntPtr(p + 0x02C)); // 0x2C OldStartingIndex            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
