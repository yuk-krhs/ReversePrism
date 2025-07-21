using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      ModelEnumType ProductKey ProductKey ProductKey Int32
    // 018 Exp                                      ModelPrimitiveType int int int Int32
    // 020 Amount                                   ModelPrimitiveType long long long Int64
    // 028 Money                                    ModelPrimitiveType int int int Int32
    // 030 SelectedAmount                           ModelPrimitiveType long long long Int64
    public partial class TrainingTicketViewModel : DataModel
    {
        public ProductKey                               Key                                     { get; set; }
        public int                                      Exp                                     { get; set; }
        public long                                     Amount                                  { get; set; }
        public int                                      Money                                   { get; set; }
        public long                                     SelectedAmount                          { get; set; }

        public static TrainingTicketViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrainingTicketViewModel() { Pointer= p0 };

            value.Key                                       = (ProductKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 Key                         ( ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.Exp                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 Exp                         ( ModelPrimitiveType int int int Int32 )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x020)); // 0x20 Amount                      ( ModelPrimitiveType long long long Int64 )
            value.Money                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Money                       ( ModelPrimitiveType int int int Int32 )
            value.SelectedAmount                            = GetInt64(new IntPtr(p + 0x030)); // 0x30 SelectedAmount              ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
