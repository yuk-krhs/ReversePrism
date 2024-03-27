using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ListChanged                              0001865367F0 ModelClassType ListChangedEventHandler ListChangedEventHandler ListChangedEventHandler Pointer
    // 038 AddingNew                                00018668BC60 ModelClassType AddingNewEventHandler AddingNewEventHandler AddingNewEventHandler Pointer
    // 040 CollectionChanged                        0001866B6E00 ModelClassType NotifyCollectionChangedEventHandler NotifyCollectionChangedEventHandler NotifyCollectionChangedEventHandler Pointer
    // 048 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    // 050 Busy                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class JContainer
    {
        public ListChangedEventHandler?                 ListChanged                             { get; set; }
        public AddingNewEventHandler?                   AddingNew                               { get; set; }
        public NotifyCollectionChangedEventHandler?     CollectionChanged                       { get; set; }
        public bool                                     Busy                                    { get; set; }

        public static JContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JContainer();

            value.ListChanged                               = GetObject<ListChangedEventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.ListChangedEventHandler.FromPointer); // 0270D87845A8 0x30 ListChanged                 ( 0001865367F0 ModelClassType ListChangedEventHandler ListChangedEventHandler ListChangedEventHandler Pointer )
            value.AddingNew                                 = GetObject<AddingNewEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.AddingNewEventHandler.FromPointer); // 0270D87845C8 0x38 AddingNew                   ( 00018668BC60 ModelClassType AddingNewEventHandler AddingNewEventHandler AddingNewEventHandler Pointer )
            value.CollectionChanged                         = GetObject<NotifyCollectionChangedEventHandler>(new IntPtr(p + 0x040), ReversePrism.DataModels.NotifyCollectionChangedEventHandler.FromPointer); // 0270D87845E8 0x40 CollectionChanged           ( 0001866B6E00 ModelClassType NotifyCollectionChangedEventHandler NotifyCollectionChangedEventHandler NotifyCollectionChangedEventHandler Pointer )
            value.Busy                                      = GetBool(new IntPtr(p + 0x050)); // 0270D8784628 0x50 Busy                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
