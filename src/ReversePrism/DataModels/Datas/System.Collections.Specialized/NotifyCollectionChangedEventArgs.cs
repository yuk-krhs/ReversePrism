using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Action                                   0001866B6210 ModelEnumType NotifyCollectionChangedAction NotifyCollectionChangedAction NotifyCollectionChangedAction Int32
    // 018 NewItems                                 000186591B20 ModelClassType IList IList IList Pointer
    // 020 OldItems                                 000186591B20 ModelClassType IList IList IList Pointer
    // 028 NewStartingIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C OldStartingIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class NotifyCollectionChangedEventArgs
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
            var value   = new NotifyCollectionChangedEventArgs();

            value.Action                                    = (NotifyCollectionChangedAction)GetInt32(new IntPtr(p + 0x010)); // 0270D7B47108 0x10 Action                      ( 0001866B6210 ModelEnumType NotifyCollectionChangedAction NotifyCollectionChangedAction NotifyCollectionChangedAction Int32 )
            value.NewItems                                  = GetObject<IList>(new IntPtr(p + 0x018), ReversePrism.DataModels.IList.FromPointer); // 0270D7B47128 0x18 NewItems                    ( 000186591B20 ModelClassType IList IList IList Pointer )
            value.OldItems                                  = GetObject<IList>(new IntPtr(p + 0x020), ReversePrism.DataModels.IList.FromPointer); // 0270D7B47148 0x20 OldItems                    ( 000186591B20 ModelClassType IList IList IList Pointer )
            value.NewStartingIndex                          = GetInt32(new IntPtr(p + 0x028)); // 0270D7B47168 0x28 NewStartingIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OldStartingIndex                          = GetInt32(new IntPtr(p + 0x02C)); // 0270D7B47188 0x2C OldStartingIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
