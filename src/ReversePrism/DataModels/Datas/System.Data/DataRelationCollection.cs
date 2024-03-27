using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InTransition                             00018667C0E0 ModelClassType DataRelation DataRelation DataRelation Pointer
    // 018 DefaultNameIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 OnCollectionChangedDelegate              0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 028 OnCollectionChangingDelegate             0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 030 ObjectID                                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class DataRelationCollection
    {
        public DataRelation?                            InTransition                            { get; set; }
        public int                                      DefaultNameIndex                        { get; set; }
        public CollectionChangeEventHandler?            OnCollectionChangedDelegate             { get; set; }
        public CollectionChangeEventHandler?            OnCollectionChangingDelegate            { get; set; }
        public int                                      ObjectID                                { get; set; }

        public static DataRelationCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataRelationCollection();

            value.InTransition                              = GetObject<DataRelation>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataRelation.FromPointer); // 0270D88D1648 0x10 InTransition                ( 00018667C0E0 ModelClassType DataRelation DataRelation DataRelation Pointer )
            value.DefaultNameIndex                          = GetInt32(new IntPtr(p + 0x018)); // 0270D88D1668 0x18 DefaultNameIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OnCollectionChangedDelegate               = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0270D88D1688 0x20 OnCollectionChangedDelegate ( 0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.OnCollectionChangingDelegate              = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0270D88D16A8 0x28 OnCollectionChangingDelegate ( 0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x030)); // 0270D88D16E8 0x30 ObjectID                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
