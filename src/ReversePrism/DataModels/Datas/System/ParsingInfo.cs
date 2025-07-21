using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Calendar                                 ModelClassType Calendar Calendar Calendar Pointer
    // 018 DayOfWeek                                ModelPrimitiveType int int int Int32
    // 01C TimeMark                                 ModelEnumType TM TM TM Int32
    // 020 FUseHour12                               ModelPrimitiveType bool bool bool Bool
    // 021 FUseTwoDigitYear                         ModelPrimitiveType bool bool bool Bool
    // 022 FAllowInnerWhite                         ModelPrimitiveType bool bool bool Bool
    // 023 FAllowTrailingWhite                      ModelPrimitiveType bool bool bool Bool
    // 024 FCustomNumberParser                      ModelPrimitiveType bool bool bool Bool
    // 028 ParseNumberDelegate                      ModelClassType MatchNumberDelegate MatchNumberDelegate MatchNumberDelegate Pointer
    public partial class ParsingInfo : DataModel
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
            var value   = new ParsingInfo() { Pointer= p0 };

            value.Calendar                                  = GetObject<Calendar>(new IntPtr(p + 0x010), ReversePrism.DataModels.Calendar.FromPointer); // 0x10 Calendar                    ( ModelClassType Calendar Calendar Calendar Pointer )
            value.DayOfWeek                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 DayOfWeek                   ( ModelPrimitiveType int int int Int32 )
            value.TimeMark                                  = (TM)GetInt32(new IntPtr(p + 0x01C)); // 0x1C TimeMark                    ( ModelEnumType TM TM TM Int32 )
            value.FUseHour12                                = GetBool(new IntPtr(p + 0x020)); // 0x20 FUseHour12                  ( ModelPrimitiveType bool bool bool Bool )
            value.FUseTwoDigitYear                          = GetBool(new IntPtr(p + 0x021)); // 0x21 FUseTwoDigitYear            ( ModelPrimitiveType bool bool bool Bool )
            value.FAllowInnerWhite                          = GetBool(new IntPtr(p + 0x022)); // 0x22 FAllowInnerWhite            ( ModelPrimitiveType bool bool bool Bool )
            value.FAllowTrailingWhite                       = GetBool(new IntPtr(p + 0x023)); // 0x23 FAllowTrailingWhite         ( ModelPrimitiveType bool bool bool Bool )
            value.FCustomNumberParser                       = GetBool(new IntPtr(p + 0x024)); // 0x24 FCustomNumberParser         ( ModelPrimitiveType bool bool bool Bool )
            value.ParseNumberDelegate                       = GetObject<MatchNumberDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.MatchNumberDelegate.FromPointer); // 0x28 ParseNumberDelegate         ( ModelClassType MatchNumberDelegate MatchNumberDelegate MatchNumberDelegate Pointer )

            return value;
        }
    }
}
