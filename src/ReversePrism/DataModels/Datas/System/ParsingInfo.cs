using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Calendar                                 0001865A1130 ModelClassType Calendar Calendar Calendar Pointer
    // 018 DayOfWeek                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C TimeMark                                 0001866EDE10 ModelEnumType TM TM TM Int32
    // 020 FUseHour12                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 021 FUseTwoDigitYear                         000186595210 ModelPrimitiveType bool bool bool Bool
    // 022 FAllowInnerWhite                         000186595210 ModelPrimitiveType bool bool bool Bool
    // 023 FAllowTrailingWhite                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 024 FCustomNumberParser                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 028 ParseNumberDelegate                      00018657DB60 ModelClassType MatchNumberDelegate MatchNumberDelegate MatchNumberDelegate Pointer
    public partial class ParsingInfo
    {
        public Calendar?                                Calendar                                { get; set; }
        public int                                      DayOfWeek                               { get; set; }
        public TM                                       TimeMark                                { get; set; }
        public bool                                     FUseHour12                              { get; set; }
        public bool                                     FUseTwoDigitYear                        { get; set; }
        public bool                                     FAllowInnerWhite                        { get; set; }
        public bool                                     FAllowTrailingWhite                     { get; set; }
        public bool                                     FCustomNumberParser                     { get; set; }
        public MatchNumberDelegate?                     ParseNumberDelegate                     { get; set; }

        public static ParsingInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParsingInfo();

            value.Calendar                                  = GetObject<Calendar>(new IntPtr(p + 0x010), ReversePrism.DataModels.Calendar.FromPointer); // 0270D6994D78 0x10 Calendar                    ( 0001865A1130 ModelClassType Calendar Calendar Calendar Pointer )
            value.DayOfWeek                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D6994D98 0x18 DayOfWeek                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.TimeMark                                  = (TM)GetInt32(new IntPtr(p + 0x01C)); // 0270D6994DB8 0x1C TimeMark                    ( 0001866EDE10 ModelEnumType TM TM TM Int32 )
            value.FUseHour12                                = GetBool(new IntPtr(p + 0x020)); // 0270D6994DD8 0x20 FUseHour12                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FUseTwoDigitYear                          = GetBool(new IntPtr(p + 0x021)); // 0270D6994DF8 0x21 FUseTwoDigitYear            ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FAllowInnerWhite                          = GetBool(new IntPtr(p + 0x022)); // 0270D6994E18 0x22 FAllowInnerWhite            ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FAllowTrailingWhite                       = GetBool(new IntPtr(p + 0x023)); // 0270D6994E38 0x23 FAllowTrailingWhite         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FCustomNumberParser                       = GetBool(new IntPtr(p + 0x024)); // 0270D6994E58 0x24 FCustomNumberParser         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ParseNumberDelegate                       = GetObject<MatchNumberDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.MatchNumberDelegate.FromPointer); // 0270D6994E78 0x28 ParseNumberDelegate         ( 00018657DB60 ModelClassType MatchNumberDelegate MatchNumberDelegate MatchNumberDelegate Pointer )

            return value;
        }
    }
}
