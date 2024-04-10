using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_storageClassType                       Type[] IL2CPP_TYPE_SZARRAY
    // 010 Column                                   000186676190 ModelClassType DataColumn DataColumn DataColumn Pointer
    // 018 Table                                    0001865B87B0 ModelClassType DataTable DataTable DataTable Pointer
    // 020 DataType                                 000186693960 ModelClassType Type Type Type Pointer
    // 028 StorageTypeCode                          00018658FC30 ModelEnumType StorageType StorageType StorageType Int32
    // 030 DbNullBits                               000186593200 ModelClassType BitArray BitArray BitArray Pointer
    // 038 _defaultValue                            <object> IL2CPP_TYPE_OBJECT
    // 040 _nullValue                               <object> IL2CPP_TYPE_OBJECT
    // 048 IsCloneable                              000186596860 ModelPrimitiveType bool bool bool Bool
    // 049 IsCustomDefinedType                      000186596860 ModelPrimitiveType bool bool bool Bool
    // 04A IsStringType                             000186596860 ModelPrimitiveType bool bool bool Bool
    // 04B IsValueType                              000186596860 ModelPrimitiveType bool bool bool Bool
    // 008 s_inspectTypeForInterfaces               Func`2<Type, Tuple`4<bool, bool, bool, bool>> IL2CPP_TYPE_GENERICINST
    // 010 s_typeImplementsInterface                ConcurrentDictionary`2<Type, Tuple`4<bool, bool, bool, bool>> IL2CPP_TYPE_GENERICINST
    public partial class DataStorage : DataModel
    {
        public DataColumn?                              Column                                  { get; set; }
        public DataTable?                               Table                                   { get; set; }
        public Type?                                    DataType                                { get; set; }
        public StorageType                              StorageTypeCode                         { get; set; }
        public BitArray?                                DbNullBits                              { get; set; }
        public bool                                     IsCloneable                             { get; set; }
        public bool                                     IsCustomDefinedType                     { get; set; }
        public bool                                     IsStringType                            { get; set; }
        public bool                                     IsValueType                             { get; set; }

        public static DataStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataStorage() { Pointer= p0 };

            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataColumn.FromPointer); // 0246689215F0 0x10 Column                      ( 000186676190 ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataTable.FromPointer); // 024668921610 0x18 Table                       ( 0001865B87B0 ModelClassType DataTable DataTable DataTable Pointer )
            value.DataType                                  = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 024668921630 0x20 DataType                    ( 000186693960 ModelClassType Type Type Type Pointer )
            value.StorageTypeCode                           = (StorageType)GetInt32(new IntPtr(p + 0x028)); // 024668921650 0x28 StorageTypeCode             ( 00018658FC30 ModelEnumType StorageType StorageType StorageType Int32 )
            value.DbNullBits                                = GetObject<BitArray>(new IntPtr(p + 0x030), ReversePrism.DataModels.BitArray.FromPointer); // 024668921670 0x30 DbNullBits                  ( 000186593200 ModelClassType BitArray BitArray BitArray Pointer )
            value.IsCloneable                               = GetBool(new IntPtr(p + 0x048)); // 0246689216D0 0x48 IsCloneable                 ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.IsCustomDefinedType                       = GetBool(new IntPtr(p + 0x049)); // 0246689216F0 0x49 IsCustomDefinedType         ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.IsStringType                              = GetBool(new IntPtr(p + 0x04A)); // 024668921710 0x4A IsStringType                ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.IsValueType                               = GetBool(new IntPtr(p + 0x04B)); // 024668921730 0x4B IsValueType                 ( 000186596860 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
