using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NIFullName                               000186671BA0 ModelPrimitiveType string string string String
    // 018 NIobjectId                               0001865F79C0 ModelPrimitiveType long long long Int64
    // 020 NIassemId                                0001865F79C0 ModelPrimitiveType long long long Int64
    // 028 NIprimitiveTypeEnum                      0001865FCE10 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32
    // 030 NItype                                   000186692A80 ModelClassType Type Type Type Pointer
    // 038 NIisSealed                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 039 NIisArray                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 03A NIisArrayItem                            000186595210 ModelPrimitiveType bool bool bool Bool
    // 03B NItransmitTypeOnObject                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 03C NItransmitTypeOnMember                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 03D NIisParentTypeOnObject                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 040 NIarrayEnum                              000186719B60 ModelEnumType InternalArrayTypeE InternalArrayTypeE InternalArrayTypeE Int32
    // 044 NIsealedStatusChecked                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class NameInfo
    {
        public string                                   NIFullName                              { get; set; }
        public long                                     NIobjectId                              { get; set; }
        public long                                     NIassemId                               { get; set; }
        public InternalPrimitiveTypeE                   NIprimitiveTypeEnum                     { get; set; }
        public Type?                                    NItype                                  { get; set; }
        public bool                                     NIisSealed                              { get; set; }
        public bool                                     NIisArray                               { get; set; }
        public bool                                     NIisArrayItem                           { get; set; }
        public bool                                     NItransmitTypeOnObject                  { get; set; }
        public bool                                     NItransmitTypeOnMember                  { get; set; }
        public bool                                     NIisParentTypeOnObject                  { get; set; }
        public InternalArrayTypeE                       NIarrayEnum                             { get; set; }
        public bool                                     NIsealedStatusChecked                   { get; set; }

        public static NameInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameInfo();

            value.NIFullName                                = GetString(new IntPtr(p + 0x010)); // 0270D6C53FA8 0x10 NIFullName                  ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NIobjectId                                = GetInt64(new IntPtr(p + 0x018)); // 0270D6C53FC8 0x18 NIobjectId                  ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.NIassemId                                 = GetInt64(new IntPtr(p + 0x020)); // 0270D6C53FE8 0x20 NIassemId                   ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.NIprimitiveTypeEnum                       = (InternalPrimitiveTypeE)GetInt32(new IntPtr(p + 0x028)); // 0270D6C54008 0x28 NIprimitiveTypeEnum         ( 0001865FCE10 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32 )
            value.NItype                                    = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0270D6C54028 0x30 NItype                      ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.NIisSealed                                = GetBool(new IntPtr(p + 0x038)); // 0270D6C54048 0x38 NIisSealed                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.NIisArray                                 = GetBool(new IntPtr(p + 0x039)); // 0270D6C54068 0x39 NIisArray                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.NIisArrayItem                             = GetBool(new IntPtr(p + 0x03A)); // 0270D6C54088 0x3A NIisArrayItem               ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.NItransmitTypeOnObject                    = GetBool(new IntPtr(p + 0x03B)); // 0270D6C540A8 0x3B NItransmitTypeOnObject      ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.NItransmitTypeOnMember                    = GetBool(new IntPtr(p + 0x03C)); // 0270D6C540C8 0x3C NItransmitTypeOnMember      ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.NIisParentTypeOnObject                    = GetBool(new IntPtr(p + 0x03D)); // 0270D6C540E8 0x3D NIisParentTypeOnObject      ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.NIarrayEnum                               = (InternalArrayTypeE)GetInt32(new IntPtr(p + 0x040)); // 0270D6C54108 0x40 NIarrayEnum                 ( 000186719B60 ModelEnumType InternalArrayTypeE InternalArrayTypeE InternalArrayTypeE Int32 )
            value.NIsealedStatusChecked                     = GetBool(new IntPtr(p + 0x044)); // 0270D6C54128 0x44 NIsealedStatusChecked       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
