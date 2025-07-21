using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ReadOnlyName                             string IL2CPP_TYPE_STRING
    // 000 CountName                                string IL2CPP_TYPE_STRING
    // 000 ComparerName                             string IL2CPP_TYPE_STRING
    // 000 HashCodeProviderName                     string IL2CPP_TYPE_STRING
    // 000 KeysName                                 string IL2CPP_TYPE_STRING
    // 000 ValuesName                               string IL2CPP_TYPE_STRING
    // 000 KeyComparerName                          string IL2CPP_TYPE_STRING
    // 000 VersionName                              string IL2CPP_TYPE_STRING
    // 010 ReadOnly                                 ModelPrimitiveType bool bool bool Bool
    // 018 EntriesArray                             ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 KeyComparer                              ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer
    // 028 EntriesTable                             ModelClassType Hashtable Hashtable Hashtable Pointer
    // 030 NullKeyEntry                             ModelClassType NameObjectEntry NameObjectEntry NameObjectEntry Pointer
    // 038 Keys                                     ModelClassType KeysCollection KeysCollection KeysCollection Pointer
    // 040 SerializationInfo                        ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    // 048 Version                                  ModelPrimitiveType int int int Int32
    // 050 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    // 000 defaultComparer                          StringComparer IL2CPP_TYPE_CLASS
    public partial class NameObjectCollectionBase : DataModel
    {
        public bool                                     ReadOnly                                { get; set; }
        public ArrayList?                               EntriesArray                            { get; set; }
        public IEqualityComparer?                       KeyComparer                             { get; set; }
        public Hashtable?                               EntriesTable                            { get; set; }
        public NameObjectEntry?                         NullKeyEntry                            { get; set; }
        public KeysCollection?                          Keys                                    { get; set; }
        public SerializationInfo?                       SerializationInfo                       { get; set; }
        public int                                      Version                                 { get; set; }

        public static NameObjectCollectionBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameObjectCollectionBase() { Pointer= p0 };

            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 ReadOnly                    ( ModelPrimitiveType bool bool bool Bool )
            value.EntriesArray                              = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0x18 EntriesArray                ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.KeyComparer                               = GetObject<IEqualityComparer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IEqualityComparer.FromPointer); // 0x20 KeyComparer                 ( ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer )
            value.EntriesTable                              = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 0x28 EntriesTable                ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.NullKeyEntry                              = GetObject<NameObjectEntry>(new IntPtr(p + 0x030), ReversePrism.DataModels.NameObjectEntry.FromPointer); // 0x30 NullKeyEntry                ( ModelClassType NameObjectEntry NameObjectEntry NameObjectEntry Pointer )
            value.Keys                                      = GetObject<KeysCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.KeysCollection.FromPointer); // 0x38 Keys                        ( ModelClassType KeysCollection KeysCollection KeysCollection Pointer )
            value.SerializationInfo                         = GetObject<SerializationInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.SerializationInfo.FromPointer); // 0x40 SerializationInfo           ( ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x048)); // 0x48 Version                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
