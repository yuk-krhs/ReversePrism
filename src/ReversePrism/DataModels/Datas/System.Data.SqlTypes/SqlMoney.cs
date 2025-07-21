using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FNotNull                                 ModelPrimitiveType bool bool bool Bool
    // 018 Value                                    ModelPrimitiveType long long long Int64
    // 000 s_iMoneyScale                            int IL2CPP_TYPE_I4
    // 008 s_lTickBase                              long IL2CPP_TYPE_I8
    // 010 S_dTickBase                              ModelPrimitiveType double double double Double
    // 018 S_minLong                                ModelPrimitiveType long long long Int64
    // 020 S_maxLong                                ModelPrimitiveType long long long Int64
    // 028 Null                                     ModelEnumType SqlMoney SqlMoney SqlMoney Int32
    // 038 Zero                                     ModelEnumType SqlMoney SqlMoney SqlMoney Int32
    // 048 MinValue                                 ModelEnumType SqlMoney SqlMoney SqlMoney Int32
    // 058 MaxValue                                 ModelEnumType SqlMoney SqlMoney SqlMoney Int32
    public partial class SqlMoney : DataModel
    {
        public bool                                     FNotNull                                { get; set; }
        public long                                     Value                                   { get; set; }
        public double                                   S_dTickBase                             { get; set; }
        public long                                     S_minLong                               { get; set; }
        public long                                     S_maxLong                               { get; set; }
        public SqlMoney                                 Null                                    { get; set; }
        public SqlMoney                                 Zero                                    { get; set; }
        public SqlMoney                                 MinValue                                { get; set; }
        public SqlMoney                                 MaxValue                                { get; set; }

        public static SqlMoney? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlMoney() { Pointer= p0 };

            value.FNotNull                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 FNotNull                    ( ModelPrimitiveType bool bool bool Bool )
            value.Value                                     = GetInt64(new IntPtr(p + 0x018)); // 0x18 Value                       ( ModelPrimitiveType long long long Int64 )
            value.S_dTickBase                               = GetDouble(new IntPtr(p + 0x010)); // 0x10 S_dTickBase                 ( ModelPrimitiveType double double double Double )
            value.S_minLong                                 = GetInt64(new IntPtr(p + 0x018)); // 0x18 S_minLong                   ( ModelPrimitiveType long long long Int64 )
            value.S_maxLong                                 = GetInt64(new IntPtr(p + 0x020)); // 0x20 S_maxLong                   ( ModelPrimitiveType long long long Int64 )
            value.Null                                      = (SqlMoney)GetInt32(new IntPtr(p + 0x028)); // 0x28 Null                        ( ModelEnumType SqlMoney SqlMoney SqlMoney Int32 )
            value.Zero                                      = (SqlMoney)GetInt32(new IntPtr(p + 0x038)); // 0x38 Zero                        ( ModelEnumType SqlMoney SqlMoney SqlMoney Int32 )
            value.MinValue                                  = (SqlMoney)GetInt32(new IntPtr(p + 0x048)); // 0x48 MinValue                    ( ModelEnumType SqlMoney SqlMoney SqlMoney Int32 )
            value.MaxValue                                  = (SqlMoney)GetInt32(new IntPtr(p + 0x058)); // 0x58 MaxValue                    ( ModelEnumType SqlMoney SqlMoney SqlMoney Int32 )

            return value;
        }
    }
}
