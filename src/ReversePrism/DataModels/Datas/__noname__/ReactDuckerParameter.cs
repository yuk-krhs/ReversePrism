using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   0001867719A0 ModelEnumType Target Target Target Int32
    // 018 TargetType                               00018654B2A0 ModelEnumType ReactDuckerTargetType ReactDuckerTargetType ReactDuckerTargetType Int32
    // 01C Entry                                    00018654BA30 ModelEnumType ReactFadeParameter ReactFadeParameter ReactFadeParameter Int32
    // 028 Exit                                     00018654BA30 ModelEnumType ReactFadeParameter ReactFadeParameter ReactFadeParameter Int32
    // 034 HoldType                                 00018654BF30 ModelEnumType ReactHoldType ReactHoldType ReactHoldType Int32
    // 038 HoldTimeMs                               000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class ReactDuckerParameter : DataModel
    {
        public Target                                   Target                                  { get; set; }
        public ReactDuckerTargetType                    TargetType                              { get; set; }
        public ReactFadeParameter                       Entry                                   { get; set; }
        public ReactFadeParameter                       Exit                                    { get; set; }
        public ReactHoldType                            HoldType                                { get; set; }
        public ushort                                   HoldTimeMs                              { get; set; }

        public static ReactDuckerParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReactDuckerParameter() { Pointer= p0 };

            value.Target                                    = (Target)GetInt32(new IntPtr(p + 0x010)); // 02466ACD65B8 0x10 Target                      ( 0001867719A0 ModelEnumType Target Target Target Int32 )
            value.TargetType                                = (ReactDuckerTargetType)GetInt32(new IntPtr(p + 0x018)); // 02466ACD65D8 0x18 TargetType                  ( 00018654B2A0 ModelEnumType ReactDuckerTargetType ReactDuckerTargetType ReactDuckerTargetType Int32 )
            value.Entry                                     = (ReactFadeParameter)GetInt32(new IntPtr(p + 0x01C)); // 02466ACD65F8 0x1C Entry                       ( 00018654BA30 ModelEnumType ReactFadeParameter ReactFadeParameter ReactFadeParameter Int32 )
            value.Exit                                      = (ReactFadeParameter)GetInt32(new IntPtr(p + 0x028)); // 02466ACD6618 0x28 Exit                        ( 00018654BA30 ModelEnumType ReactFadeParameter ReactFadeParameter ReactFadeParameter Int32 )
            value.HoldType                                  = (ReactHoldType)GetInt32(new IntPtr(p + 0x034)); // 02466ACD6638 0x34 HoldType                    ( 00018654BF30 ModelEnumType ReactHoldType ReactHoldType ReactHoldType Int32 )
            value.HoldTimeMs                                = GetUInt16(new IntPtr(p + 0x038)); // 02466ACD6658 0x38 HoldTimeMs                  ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
