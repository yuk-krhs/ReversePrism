using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSelectedRP                             0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 OnGrayOutRP                              0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 020 Key                                      0001865A2170 ModelEnumType ProductKey ProductKey ProductKey Int32
    // 028 Amount                                   0001865F7700 ModelPrimitiveType long long long Int64
    // 030 RequiredToMaxAmount                      0001865F4260 ModelPrimitiveType int int int Int32
    // 038 SurplusAmount                            0001865F7700 ModelPrimitiveType long long long Int64
    public partial class PieceIcon : DataModel
    {
        public BoolReactiveProperty?                    OnSelectedRP                            { get; set; }
        public BoolReactiveProperty?                    OnGrayOutRP                             { get; set; }
        public ProductKey                               Key                                     { get; set; }
        public long                                     Amount                                  { get; set; }
        public int                                      RequiredToMaxAmount                     { get; set; }
        public long                                     SurplusAmount                           { get; set; }

        public static PieceIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceIcon() { Pointer= p0 };

            value.OnSelectedRP                              = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 024665A00ED0 0x10 OnSelectedRP                ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.OnGrayOutRP                               = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 024665A00EF0 0x18 OnGrayOutRP                 ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.Key                                       = (ProductKey)GetInt32(new IntPtr(p + 0x020)); // 024665A00F10 0x20 Key                         ( 0001865A2170 ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x028)); // 024665A00F30 0x28 Amount                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.RequiredToMaxAmount                       = GetInt32(new IntPtr(p + 0x030)); // 024665A00F50 0x30 RequiredToMaxAmount         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SurplusAmount                             = GetInt64(new IntPtr(p + 0x038)); // 024665A00F70 0x38 SurplusAmount               ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
