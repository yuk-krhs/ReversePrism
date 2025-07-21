using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ListChanged                              ModelClassType ListChangedEventHandler ListChangedEventHandler ListChangedEventHandler Pointer
    // 038 AddingNew                                ModelClassType AddingNewEventHandler AddingNewEventHandler AddingNewEventHandler Pointer
    // 040 CollectionChanged                        ModelClassType NotifyCollectionChangedEventHandler NotifyCollectionChangedEventHandler NotifyCollectionChangedEventHandler Pointer
    // 048 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    // 050 Busy                                     ModelPrimitiveType bool bool bool Bool
    public partial class JContainer : DataModel
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
            var value   = new JContainer() { Pointer= p0 };

            value.ListChanged                               = GetObject<ListChangedEventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.ListChangedEventHandler.FromPointer); // 0x30 ListChanged                 ( ModelClassType ListChangedEventHandler ListChangedEventHandler ListChangedEventHandler Pointer )
            value.AddingNew                                 = GetObject<AddingNewEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.AddingNewEventHandler.FromPointer); // 0x38 AddingNew                   ( ModelClassType AddingNewEventHandler AddingNewEventHandler AddingNewEventHandler Pointer )
            value.CollectionChanged                         = GetObject<NotifyCollectionChangedEventHandler>(new IntPtr(p + 0x040), ReversePrism.DataModels.NotifyCollectionChangedEventHandler.FromPointer); // 0x40 CollectionChanged           ( ModelClassType NotifyCollectionChangedEventHandler NotifyCollectionChangedEventHandler NotifyCollectionChangedEventHandler Pointer )
            value.Busy                                      = GetBool(new IntPtr(p + 0x050)); // 0x50 Busy                        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
