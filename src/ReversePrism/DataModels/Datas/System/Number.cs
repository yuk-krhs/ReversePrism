using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DecimalPrecision                         int IL2CPP_TYPE_I4
    // 000 SinglePrecision                          int IL2CPP_TYPE_I4
    // 000 DoublePrecision                          int IL2CPP_TYPE_I4
    // 000 SinglePrecisionCustomFormat              int IL2CPP_TYPE_I4
    // 000 DoublePrecisionCustomFormat              int IL2CPP_TYPE_I4
    // 000 DefaultPrecisionExponentialFormat        int IL2CPP_TYPE_I4
    // 000 MaxUInt32DecDigits                       int IL2CPP_TYPE_I4
    // 000 CharStackBufferSize                      int IL2CPP_TYPE_I4
    // 000 PosNumberFormat                          string IL2CPP_TYPE_STRING
    // 000 s_singleDigitStringCache                 string[] IL2CPP_TYPE_SZARRAY
    // 008 s_posCurrencyFormats                     string[] IL2CPP_TYPE_SZARRAY
    // 010 S_negCurrencyFormats                     000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 S_posPercentFormats                      000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 S_negPercentFormats                      000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 S_negNumberFormats                       000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 000 DecimalNumberBufferLength                int IL2CPP_TYPE_I4
    // 000 DoubleNumberBufferLength                 int IL2CPP_TYPE_I4
    // 000 Int32NumberBufferLength                  int IL2CPP_TYPE_I4
    // 000 Int64NumberBufferLength                  int IL2CPP_TYPE_I4
    // 000 SingleNumberBufferLength                 int IL2CPP_TYPE_I4
    // 000 UInt32NumberBufferLength                 int IL2CPP_TYPE_I4
    // 000 UInt64NumberBufferLength                 int IL2CPP_TYPE_I4
    // 030 S_Pow10SingleTable                       000185B80E40 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 038 S_Pow10DoubleTable                       000185B7CC40 ModelPrimitiveListType double[] double[] List<double> Pointer
    // 000 Int32Precision                           int IL2CPP_TYPE_I4
    // 000 UInt32Precision                          int IL2CPP_TYPE_I4
    // 000 Int64Precision                           int IL2CPP_TYPE_I4
    // 000 UInt64Precision                          int IL2CPP_TYPE_I4
    // 000 DoubleMaxExponent                        int IL2CPP_TYPE_I4
    // 000 DoubleMinExponent                        int IL2CPP_TYPE_I4
    // 000 FloatingPointMaxExponent                 int IL2CPP_TYPE_I4
    // 000 FloatingPointMinExponent                 int IL2CPP_TYPE_I4
    // 000 SingleMaxExponent                        int IL2CPP_TYPE_I4
    // 000 SingleMinExponent                        int IL2CPP_TYPE_I4
    public partial class Number
    {
        public List<string>?                            S_negCurrencyFormats                    { get; set; }
        public List<string>?                            S_posPercentFormats                     { get; set; }
        public List<string>?                            S_negPercentFormats                     { get; set; }
        public List<string>?                            S_negNumberFormats                      { get; set; }
        public List<float>?                             S_Pow10SingleTable                      { get; set; }
        public List<double>?                            S_Pow10DoubleTable                      { get; set; }

        public static Number? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Number();

            value.S_negCurrencyFormats                      = GetStringList(new IntPtr(p + 0x010)); // 0270DAAAB8D8 0x10 S_negCurrencyFormats        ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.S_posPercentFormats                       = GetStringList(new IntPtr(p + 0x018)); // 0270DAAAB8F8 0x18 S_posPercentFormats         ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.S_negPercentFormats                       = GetStringList(new IntPtr(p + 0x020)); // 0270DAAAB918 0x20 S_negPercentFormats         ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.S_negNumberFormats                        = GetStringList(new IntPtr(p + 0x028)); // 0270DAAAB938 0x28 S_negNumberFormats          ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.S_Pow10SingleTable                        = GetSingleList(new IntPtr(p + 0x030)); // 0270DAAABA38 0x30 S_Pow10SingleTable          ( 000185B80E40 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.S_Pow10DoubleTable                        = GetDoubleList(new IntPtr(p + 0x038)); // 0270DAAABA58 0x38 S_Pow10DoubleTable          ( 000185B7CC40 ModelPrimitiveListType double[] double[] List<double> Pointer )

            return value;
        }
    }
}
