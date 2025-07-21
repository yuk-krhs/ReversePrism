using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HashPrime                                int IL2CPP_TYPE_I4
    // 000 InitialSize                              int IL2CPP_TYPE_I4
    // 000 LoadFactorName                           string IL2CPP_TYPE_STRING
    // 000 VersionName                              string IL2CPP_TYPE_STRING
    // 000 ComparerName                             string IL2CPP_TYPE_STRING
    // 000 HashCodeProviderName                     string IL2CPP_TYPE_STRING
    // 000 HashSizeName                             string IL2CPP_TYPE_STRING
    // 000 KeysName                                 string IL2CPP_TYPE_STRING
    // 000 ValuesName                               string IL2CPP_TYPE_STRING
    // 000 KeyComparerName                          string IL2CPP_TYPE_STRING
    // 010 Buckets                                  ModelEnumListType bucket[] bucket[] List<bucket> Pointer
    // 018 Count                                    ModelPrimitiveType int int int Int32
    // 01C Occupancy                                ModelPrimitiveType int int int Int32
    // 020 Loadsize                                 ModelPrimitiveType int int int Int32
    // 024 LoadFactor                               ModelPrimitiveType float float float Single
    // 028 Version                                  ModelPrimitiveType int int int Int32
    // 02C IsWriterInProgress                       ModelPrimitiveType bool bool bool Bool
    // 030 Keys                                     ModelClassType ICollection ICollection ICollection Pointer
    // 038 Values                                   ModelClassType ICollection ICollection ICollection Pointer
    // 040 Keycomparer                              ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer
    // 048 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    // 000 s_serializationInfoTable                 ConditionalWeakTable`2<<object>, SerializationInfo> IL2CPP_TYPE_GENERICINST
    public partial class Hashtable : DataModel
    {
        public List<bucket>?                            Buckets                                 { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      Occupancy                               { get; set; }
        public int                                      Loadsize                                { get; set; }
        public float                                    LoadFactor                              { get; set; }
        public int                                      Version                                 { get; set; }
        public bool                                     IsWriterInProgress                      { get; set; }
        public ICollection?                             Keys                                    { get; set; }
        public ICollection?                             Values                                  { get; set; }
        public IEqualityComparer?                       Keycomparer                             { get; set; }

        public static Hashtable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Hashtable() { Pointer= p0 };

            value.Buckets                                   = GetEnumList<bucket>(new IntPtr(p + 0x010)); // 0x10 Buckets                     ( ModelEnumListType bucket[] bucket[] List<bucket> Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Count                       ( ModelPrimitiveType int int int Int32 )
            value.Occupancy                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Occupancy                   ( ModelPrimitiveType int int int Int32 )
            value.Loadsize                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 Loadsize                    ( ModelPrimitiveType int int int Int32 )
            value.LoadFactor                                = GetSingle(new IntPtr(p + 0x024)); // 0x24 LoadFactor                  ( ModelPrimitiveType float float float Single )
            value.Version                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 Version                     ( ModelPrimitiveType int int int Int32 )
            value.IsWriterInProgress                        = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsWriterInProgress          ( ModelPrimitiveType bool bool bool Bool )
            value.Keys                                      = GetObject<ICollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.ICollection.FromPointer); // 0x30 Keys                        ( ModelClassType ICollection ICollection ICollection Pointer )
            value.Values                                    = GetObject<ICollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICollection.FromPointer); // 0x38 Values                      ( ModelClassType ICollection ICollection ICollection Pointer )
            value.Keycomparer                               = GetObject<IEqualityComparer>(new IntPtr(p + 0x040), ReversePrism.DataModels.IEqualityComparer.FromPointer); // 0x40 Keycomparer                 ( ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer )

            return value;
        }
    }
}
