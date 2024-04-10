using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32
    // 018 Exp                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Amount                                   0001865F7700 ModelPrimitiveType long long long Int64
    // 028 Money                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 SelectedAmount                           0001865F7700 ModelPrimitiveType long long long Int64
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

            value.Key                                       = (ProductKey)GetInt32(new IntPtr(p + 0x010)); // 0246660A57C0 0x10 Key                         ( 0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.Exp                                       = GetInt32(new IntPtr(p + 0x018)); // 0246660A57E0 0x18 Exp                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x020)); // 0246660A5800 0x20 Amount                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Money                                     = GetInt32(new IntPtr(p + 0x028)); // 0246660A5820 0x28 Money                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedAmount                            = GetInt64(new IntPtr(p + 0x030)); // 0246660A5840 0x30 SelectedAmount              ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
