using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<HomeVoiceMotionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstHomeVoiceMotionIdFieldNumber          int IL2CPP_TYPE_I4
    // 018 MstHomeVoiceMotionId                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 WeatherFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Weather                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VoiceFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Voice                                    000186539B30 ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer
    // 000 VoiceTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 030 VoiceType                                0001866D4770 ModelEnumType HomeVoiceType HomeVoiceType HomeVoiceType Int32
    public partial class HomeVoiceMotionStatus
    {
        public int                                      MstHomeVoiceMotionId                    { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public int                                      Weather                                 { get; set; }
        public VoiceResourceStatus?                     Voice                                   { get; set; }
        public HomeVoiceType                            VoiceType                               { get; set; }

        public static HomeVoiceMotionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeVoiceMotionStatus();

            value.MstHomeVoiceMotionId                      = GetInt32(new IntPtr(p + 0x018)); // 0270D2065188 0x18 MstHomeVoiceMotionId        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D20651C8 0x1C MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Weather                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D2065208 0x20 Weather                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Voice                                     = GetObject<VoiceResourceStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.VoiceResourceStatus.FromPointer); // 0270D2065248 0x28 Voice                       ( 000186539B30 ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer )
            value.VoiceType                                 = (HomeVoiceType)GetInt32(new IntPtr(p + 0x030)); // 0270D2065288 0x30 VoiceType                   ( 0001866D4770 ModelEnumType HomeVoiceType HomeVoiceType HomeVoiceType Int32 )

            return value;
        }
    }
}
