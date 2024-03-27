using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Member                                   0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 020 ColumnType                               000186692850 ModelClassType Type Type Type Pointer
    // 028 Collation                                000186671910 ModelPrimitiveType string string string String
    // 030 IsAutoInc                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 IsAutoGuid                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 IsPK                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 <Indices>k__BackingField                 IEnumerable`1<IndexedAttribute> IL2CPP_TYPE_GENERICINST
    // 040 IsNullable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 <MaxStringLength>k__BackingField         Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 04C StoreAsText                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Column
    {
        public MemberInfo?                              Member                                  { get; set; }
        public string                                   Name                                    { get; set; }
        public Type?                                    ColumnType                              { get; set; }
        public string                                   Collation                               { get; set; }
        public bool                                     IsAutoInc                               { get; set; }
        public bool                                     IsAutoGuid                              { get; set; }
        public bool                                     IsPK                                    { get; set; }
        public bool                                     IsNullable                              { get; set; }
        public bool                                     StoreAsText                             { get; set; }

        public static Column? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Column();

            value.Member                                    = GetObject<MemberInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MemberInfo.FromPointer); // 027003D73760 0x10 Member                      ( 0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 027003D73780 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.ColumnType                                = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 027003D737A0 0x20 ColumnType                  ( 000186692850 ModelClassType Type Type Type Pointer )
            value.Collation                                 = GetString(new IntPtr(p + 0x028)); // 027003D737C0 0x28 Collation                   ( 000186671910 ModelPrimitiveType string string string String )
            value.IsAutoInc                                 = GetBool(new IntPtr(p + 0x030)); // 027003D737E0 0x30 IsAutoInc                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAutoGuid                                = GetBool(new IntPtr(p + 0x031)); // 027003D73800 0x31 IsAutoGuid                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPK                                      = GetBool(new IntPtr(p + 0x032)); // 027003D73820 0x32 IsPK                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNullable                                = GetBool(new IntPtr(p + 0x040)); // 027003D73860 0x40 IsNullable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.StoreAsText                               = GetBool(new IntPtr(p + 0x04C)); // 027003D738A0 0x4C StoreAsText                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
