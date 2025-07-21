using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSelectedRP                             ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 OnGrayOutRP                              ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 020 Key                                      ModelEnumType ProductKey ProductKey ProductKey Int32
    // 028 Amount                                   ModelPrimitiveType long long long Int64
    // 030 RequiredToMaxAmount                      ModelPrimitiveType int int int Int32
    // 038 SurplusAmount                            ModelPrimitiveType long long long Int64
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

            value.OnSelectedRP                              = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 OnSelectedRP                ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.OnGrayOutRP                               = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x18 OnGrayOutRP                 ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.Key                                       = (ProductKey)GetInt32(new IntPtr(p + 0x020)); // 0x20 Key                         ( ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x028)); // 0x28 Amount                      ( ModelPrimitiveType long long long Int64 )
            value.RequiredToMaxAmount                       = GetInt32(new IntPtr(p + 0x030)); // 0x30 RequiredToMaxAmount         ( ModelPrimitiveType int int int Int32 )
            value.SurplusAmount                             = GetInt64(new IntPtr(p + 0x038)); // 0x38 SurplusAmount               ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
