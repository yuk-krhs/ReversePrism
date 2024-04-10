using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CountPropertyChanged                     PropertyChangedEventArgs IL2CPP_TYPE_CLASS
    // 008 IndexerPropertyChanged                   PropertyChangedEventArgs IL2CPP_TYPE_CLASS
    // 010 ResetCollectionChanged                   0001866B6940 ModelClassType NotifyCollectionChangedEventArgs NotifyCollectionChangedEventArgs NotifyCollectionChangedEventArgs Pointer
    public partial class EventArgsCache : DataModel
    {
        public NotifyCollectionChangedEventArgs?        ResetCollectionChanged                  { get; set; }

        public static EventArgsCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventArgsCache() { Pointer= p0 };

            value.ResetCollectionChanged                    = GetObject<NotifyCollectionChangedEventArgs>(new IntPtr(p + 0x010), ReversePrism.DataModels.NotifyCollectionChangedEventArgs.FromPointer); // 024667BAF2D8 0x10 ResetCollectionChanged      ( 0001866B6940 ModelClassType NotifyCollectionChangedEventArgs NotifyCollectionChangedEventArgs NotifyCollectionChangedEventArgs Pointer )

            return value;
        }
    }
}
