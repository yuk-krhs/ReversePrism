using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Positive                                 000185B7DC00 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 NegativeASCII                            000185B7DC00 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 NegativeUnicode                          int[][] IL2CPP_TYPE_SZARRAY
    // 028 Pattern                                  0001866736C0 ModelPrimitiveType string string string String
    // 030 LowASCII                                 0001865F4940 ModelPrimitiveType int int int Int32
    // 034 HighASCII                                0001865F4940 ModelPrimitiveType int int int Int32
    // 038 RightToLeft                              000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 039 CaseInsensitive                          000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 040 Culture                                  0001865B51E0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    public partial class RegexBoyerMoore
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
            var value   = new RegexBoyerMoore();

            value.Positive                                  = GetInt32List(new IntPtr(p + 0x010)); // 0270034236A0 0x10 Positive                    ( 000185B7DC00 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.NegativeASCII                             = GetInt32List(new IntPtr(p + 0x018)); // 0270034236C0 0x18 NegativeASCII               ( 000185B7DC00 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Pattern                                   = GetString(new IntPtr(p + 0x028)); // 027003423700 0x28 Pattern                     ( 0001866736C0 ModelPrimitiveType string string string String )
            value.LowASCII                                  = GetInt32(new IntPtr(p + 0x030)); // 027003423720 0x30 LowASCII                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.HighASCII                                 = GetInt32(new IntPtr(p + 0x034)); // 027003423740 0x34 HighASCII                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.RightToLeft                               = GetBool(new IntPtr(p + 0x038)); // 027003423760 0x38 RightToLeft                 ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.CaseInsensitive                           = GetBool(new IntPtr(p + 0x039)); // 027003423780 0x39 CaseInsensitive             ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.CultureInfo.FromPointer); // 0270034237A0 0x40 Culture                     ( 0001865B51E0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )

            return value;
        }
    }
}
