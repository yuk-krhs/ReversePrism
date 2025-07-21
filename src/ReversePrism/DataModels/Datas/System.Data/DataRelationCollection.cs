using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InTransition                             ModelClassType DataRelation DataRelation DataRelation Pointer
    // 018 DefaultNameIndex                         ModelPrimitiveType int int int Int32
    // 020 OnCollectionChangedDelegate              ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 028 OnCollectionChangingDelegate             ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 030 ObjectID                                 ModelPrimitiveType int int int Int32
    public partial class DataRelationCollection : DataModel
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
            var value   = new DataRelationCollection() { Pointer= p0 };

            value.InTransition                              = GetObject<DataRelation>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataRelation.FromPointer); // 0x10 InTransition                ( ModelClassType DataRelation DataRelation DataRelation Pointer )
            value.DefaultNameIndex                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 DefaultNameIndex            ( ModelPrimitiveType int int int Int32 )
            value.OnCollectionChangedDelegate               = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0x20 OnCollectionChangedDelegate ( ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.OnCollectionChangingDelegate              = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0x28 OnCollectionChangingDelegate ( ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 ObjectID                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
