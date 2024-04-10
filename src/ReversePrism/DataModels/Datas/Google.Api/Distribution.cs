using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Distribution> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CountFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Count                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 000 MeanFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Mean                                     0001865C2950 ModelPrimitiveType double double double Double
    // 000 SumOfSquaredDeviationFieldNumber         int IL2CPP_TYPE_I4
    // 028 SumOfSquaredDeviation                    0001865C2950 ModelPrimitiveType double double double Double
    // 000 RangeFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Range                                    00018677A050 ModelClassType Range Range Range Pointer
    // 000 BucketOptionsFieldNumber                 int IL2CPP_TYPE_I4
    // 038 BucketOptions                            0001867798D0 ModelClassType BucketOptions BucketOptions BucketOptions Pointer
    // 000 BucketCountsFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_bucketCounts_codec             FieldCodec`1<long> IL2CPP_TYPE_GENERICINST
    // 040 BucketCounts                             000185CE1F28 ModelPrimitiveListType RepeatedField`1<long> RepeatedField`1<long> List<long> Pointer
    // 000 ExemplarsFieldNumber                     int IL2CPP_TYPE_I4
    // 010 _repeated_exemplars_codec                FieldCodec`1<Exemplar> IL2CPP_TYPE_GENERICINST
    // 048 Exemplars                                000185CF8908 ModelClassListType RepeatedField`1<Exemplar> RepeatedField`1<Exemplar> List<Exemplar> Pointer
    public partial class Distribution : DataModel
    {
        public long                                     Count                                   { get; set; }
        public double                                   Mean                                    { get; set; }
        public double                                   SumOfSquaredDeviation                   { get; set; }
        public Range?                                   Range                                   { get; set; }
        public BucketOptions?                           BucketOptions                           { get; set; }
        public List<long>?                              BucketCounts                            { get; set; }
        public List<Exemplar>?                          Exemplars                               { get; set; }

        public static Distribution? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Distribution() { Pointer= p0 };

            value.Count                                     = GetInt64(new IntPtr(p + 0x018)); // 02466A7F7138 0x18 Count                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Mean                                      = GetDouble(new IntPtr(p + 0x020)); // 02466A7F7178 0x20 Mean                        ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.SumOfSquaredDeviation                     = GetDouble(new IntPtr(p + 0x028)); // 02466A7F71B8 0x28 SumOfSquaredDeviation       ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.Range                                     = GetObject<Range>(new IntPtr(p + 0x030), ReversePrism.DataModels.Range.FromPointer); // 02466A7F71F8 0x30 Range                       ( 00018677A050 ModelClassType Range Range Range Pointer )
            value.BucketOptions                             = GetObject<BucketOptions>(new IntPtr(p + 0x038), ReversePrism.DataModels.BucketOptions.FromPointer); // 02466A7F7238 0x38 BucketOptions               ( 0001867798D0 ModelClassType BucketOptions BucketOptions BucketOptions Pointer )
            value.BucketCounts                              = GetInt64List(new IntPtr(p + 0x040)); // 02466A7F7298 0x40 BucketCounts                ( 000185CE1F28 ModelPrimitiveListType RepeatedField`1<long> RepeatedField`1<long> List<long> Pointer )
            value.Exemplars                                 = GetObjectList<Exemplar>(new IntPtr(p + 0x048), ReversePrism.DataModels.Exemplar.FromPointer); // 02466A7F72F8 0x48 Exemplars                   ( 000185CF8908 ModelClassListType RepeatedField`1<Exemplar> RepeatedField`1<Exemplar> List<Exemplar> Pointer )

            return value;
        }
    }
}
