using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaBonusRateStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductRateListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_productRateList_codec          FieldCodec`1<GashaBonusProductRateStatus> IL2CPP_TYPE_GENERICINST
    // 018 ProductRateList                          000185CDA8B8 ModelClassListType RepeatedField`1<GashaBonusProductRateStatus> RepeatedField`1<GashaBonusProductRateStatus> List<GashaBonusProductRateStatus> Pointer
    // 000 BonusIdFieldNumber                       int IL2CPP_TYPE_I4
    // 020 BonusId                                  000186671910 ModelPrimitiveType string string string String
    // 000 BodyFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Body                                     000186671910 ModelPrimitiveType string string string String
    // 000 CaptionFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Caption                                  000186671910 ModelPrimitiveType string string string String
    // 000 StepNoFieldNumber                        int IL2CPP_TYPE_I4
    // 038 StepNo                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GashaBonusRateStatus
    {
        public List<GashaBonusProductRateStatus>?       ProductRateList                         { get; set; }
        public string                                   BonusId                                 { get; set; }
        public string                                   Body                                    { get; set; }
        public string                                   Caption                                 { get; set; }
        public int                                      StepNo                                  { get; set; }

        public static GashaBonusRateStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaBonusRateStatus();

            value.ProductRateList                           = GetObjectList<GashaBonusProductRateStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaBonusProductRateStatus.FromPointer); // 0270D15844F0 0x18 ProductRateList             ( 000185CDA8B8 ModelClassListType RepeatedField`1<GashaBonusProductRateStatus> RepeatedField`1<GashaBonusProductRateStatus> List<GashaBonusProductRateStatus> Pointer )
            value.BonusId                                   = GetString(new IntPtr(p + 0x020)); // 0270D1584530 0x20 BonusId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Body                                      = GetString(new IntPtr(p + 0x028)); // 0270D1584570 0x28 Body                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Caption                                   = GetString(new IntPtr(p + 0x030)); // 0270D15845B0 0x30 Caption                     ( 000186671910 ModelPrimitiveType string string string String )
            value.StepNo                                    = GetInt32(new IntPtr(p + 0x038)); // 0270D15845F0 0x38 StepNo                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
