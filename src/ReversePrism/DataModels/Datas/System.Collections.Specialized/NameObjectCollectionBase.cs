using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReadOnly                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 EntriesArray                             00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 KeyComparer                              000186762030 ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer
    // 028 EntriesTable                             0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 030 NullKeyEntry                             00018676F6B0 ModelClassType NameObjectEntry NameObjectEntry NameObjectEntry Pointer
    // 038 SerializationInfo                        0001866636F0 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    // 040 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    // 000 defaultComparer                          StringComparer IL2CPP_TYPE_CLASS
    public partial class NameObjectCollectionBase
    {
        public bool                                     ReadOnly                                { get; set; }
        public ArrayList?                               EntriesArray                            { get; set; }
        public IEqualityComparer?                       KeyComparer                             { get; set; }
        public Hashtable?                               EntriesTable                            { get; set; }
        public NameObjectEntry?                         NullKeyEntry                            { get; set; }
        public SerializationInfo?                       SerializationInfo                       { get; set; }
        public int                                      Version                                 { get; set; }

        public static NameObjectCollectionBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameObjectCollectionBase();

            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x010)); // 0270D7987578 0x10 ReadOnly                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EntriesArray                              = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D7987598 0x18 EntriesArray                ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.KeyComparer                               = GetObject<IEqualityComparer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IEqualityComparer.FromPointer); // 0270D79875B8 0x20 KeyComparer                 ( 000186762030 ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer )
            value.EntriesTable                              = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D79875D8 0x28 EntriesTable                ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.NullKeyEntry                              = GetObject<NameObjectEntry>(new IntPtr(p + 0x030), ReversePrism.DataModels.NameObjectEntry.FromPointer); // 0270D79875F8 0x30 NullKeyEntry                ( 00018676F6B0 ModelClassType NameObjectEntry NameObjectEntry NameObjectEntry Pointer )
            value.SerializationInfo                         = GetObject<SerializationInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.SerializationInfo.FromPointer); // 0270D7987618 0x38 SerializationInfo           ( 0001866636F0 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x040)); // 0270D7987638 0x40 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
