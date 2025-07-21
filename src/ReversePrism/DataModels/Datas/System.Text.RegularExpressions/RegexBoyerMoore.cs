using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Positive                                 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 NegativeASCII                            ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 NegativeUnicode                          int[][] IL2CPP_TYPE_SZARRAY
    // 028 Pattern                                  ModelPrimitiveType string string string String
    // 030 LowASCII                                 ModelPrimitiveType int int int Int32
    // 034 HighASCII                                ModelPrimitiveType int int int Int32
    // 038 RightToLeft                              ModelPrimitiveType bool bool bool Bool
    // 039 CaseInsensitive                          ModelPrimitiveType bool bool bool Bool
    // 040 Culture                                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    public partial class RegexBoyerMoore : DataModel
    {
        public List<int>?                               Positive                                { get; set; }
        public List<int>?                               NegativeASCII                           { get; set; }
        public string                                   Pattern                                 { get; set; }
        public int                                      LowASCII                                { get; set; }
        public int                                      HighASCII                               { get; set; }
        public bool                                     RightToLeft                             { get; set; }
        public bool                                     CaseInsensitive                         { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }

        public static RegexBoyerMoore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexBoyerMoore() { Pointer= p0 };

            value.Positive                                  = GetInt32List(new IntPtr(p + 0x010)); // 0x10 Positive                    ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.NegativeASCII                             = GetInt32List(new IntPtr(p + 0x018)); // 0x18 NegativeASCII               ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Pattern                                   = GetString(new IntPtr(p + 0x028)); // 0x28 Pattern                     ( ModelPrimitiveType string string string String )
            value.LowASCII                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 LowASCII                    ( ModelPrimitiveType int int int Int32 )
            value.HighASCII                                 = GetInt32(new IntPtr(p + 0x034)); // 0x34 HighASCII                   ( ModelPrimitiveType int int int Int32 )
            value.RightToLeft                               = GetBool(new IntPtr(p + 0x038)); // 0x38 RightToLeft                 ( ModelPrimitiveType bool bool bool Bool )
            value.CaseInsensitive                           = GetBool(new IntPtr(p + 0x039)); // 0x39 CaseInsensitive             ( ModelPrimitiveType bool bool bool Bool )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x40 Culture                     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )

            return value;
        }
    }
}
