using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelEnumType Target Target Target Int32
    // 018 TargetType                               ModelEnumType ReactDuckerTargetType ReactDuckerTargetType ReactDuckerTargetType Int32
    // 01C Entry                                    ModelEnumType ReactFadeParameter ReactFadeParameter ReactFadeParameter Int32
    // 028 Exit                                     ModelEnumType ReactFadeParameter ReactFadeParameter ReactFadeParameter Int32
    // 034 HoldType                                 ModelEnumType ReactHoldType ReactHoldType ReactHoldType Int32
    // 038 HoldTimeMs                               ModelPrimitiveType ushort ushort ushort UInt16
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

            value.Target                                    = (Target)GetInt32(new IntPtr(p + 0x010)); // 0x10 Target                      ( ModelEnumType Target Target Target Int32 )
            value.TargetType                                = (ReactDuckerTargetType)GetInt32(new IntPtr(p + 0x018)); // 0x18 TargetType                  ( ModelEnumType ReactDuckerTargetType ReactDuckerTargetType ReactDuckerTargetType Int32 )
            value.Entry                                     = (ReactFadeParameter)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Entry                       ( ModelEnumType ReactFadeParameter ReactFadeParameter ReactFadeParameter Int32 )
            value.Exit                                      = (ReactFadeParameter)GetInt32(new IntPtr(p + 0x028)); // 0x28 Exit                        ( ModelEnumType ReactFadeParameter ReactFadeParameter ReactFadeParameter Int32 )
            value.HoldType                                  = (ReactHoldType)GetInt32(new IntPtr(p + 0x034)); // 0x34 HoldType                    ( ModelEnumType ReactHoldType ReactHoldType ReactHoldType Int32 )
            value.HoldTimeMs                                = GetUInt16(new IntPtr(p + 0x038)); // 0x38 HoldTimeMs                  ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
