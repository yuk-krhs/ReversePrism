using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_storageClassType                       Type[] IL2CPP_TYPE_SZARRAY
    // 010 Column                                   ModelClassType DataColumn DataColumn DataColumn Pointer
    // 018 Table                                    ModelClassType DataTable DataTable DataTable Pointer
    // 020 DataType                                 ModelClassType Type Type Type Pointer
    // 028 StorageTypeCode                          ModelEnumType StorageType StorageType StorageType Int32
    // 030 DbNullBits                               ModelClassType BitArray BitArray BitArray Pointer
    // 038 _defaultValue                            <object> IL2CPP_TYPE_OBJECT
    // 040 _nullValue                               <object> IL2CPP_TYPE_OBJECT
    // 048 IsCloneable                              ModelPrimitiveType bool bool bool Bool
    // 049 IsCustomDefinedType                      ModelPrimitiveType bool bool bool Bool
    // 04A IsStringType                             ModelPrimitiveType bool bool bool Bool
    // 04B IsValueType                              ModelPrimitiveType bool bool bool Bool
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

            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataColumn.FromPointer); // 0x10 Column                      ( ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataTable.FromPointer); // 0x18 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )
            value.DataType                                  = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 DataType                    ( ModelClassType Type Type Type Pointer )
            value.StorageTypeCode                           = (StorageType)GetInt32(new IntPtr(p + 0x028)); // 0x28 StorageTypeCode             ( ModelEnumType StorageType StorageType StorageType Int32 )
            value.DbNullBits                                = GetObject<BitArray>(new IntPtr(p + 0x030), ReversePrism.DataModels.BitArray.FromPointer); // 0x30 DbNullBits                  ( ModelClassType BitArray BitArray BitArray Pointer )
            value.IsCloneable                               = GetBool(new IntPtr(p + 0x048)); // 0x48 IsCloneable                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsCustomDefinedType                       = GetBool(new IntPtr(p + 0x049)); // 0x49 IsCustomDefinedType         ( ModelPrimitiveType bool bool bool Bool )
            value.IsStringType                              = GetBool(new IntPtr(p + 0x04A)); // 0x4A IsStringType                ( ModelPrimitiveType bool bool bool Bool )
            value.IsValueType                               = GetBool(new IntPtr(p + 0x04B)); // 0x4B IsValueType                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
