using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NIFullName                               ModelPrimitiveType string string string String
    // 018 NIobjectId                               ModelPrimitiveType long long long Int64
    // 020 NIassemId                                ModelPrimitiveType long long long Int64
    // 028 NIprimitiveTypeEnum                      ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32
    // 030 NItype                                   ModelClassType Type Type Type Pointer
    // 038 NIisSealed                               ModelPrimitiveType bool bool bool Bool
    // 039 NIisArray                                ModelPrimitiveType bool bool bool Bool
    // 03A NIisArrayItem                            ModelPrimitiveType bool bool bool Bool
    // 03B NItransmitTypeOnObject                   ModelPrimitiveType bool bool bool Bool
    // 03C NItransmitTypeOnMember                   ModelPrimitiveType bool bool bool Bool
    // 03D NIisParentTypeOnObject                   ModelPrimitiveType bool bool bool Bool
    // 040 NIarrayEnum                              ModelEnumType InternalArrayTypeE InternalArrayTypeE InternalArrayTypeE Int32
    // 044 NIsealedStatusChecked                    ModelPrimitiveType bool bool bool Bool
    public partial class NameInfo : DataModel
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
            var value   = new NameInfo() { Pointer= p0 };

            value.NIFullName                                = GetString(new IntPtr(p + 0x010)); // 0x10 NIFullName                  ( ModelPrimitiveType string string string String )
            value.NIobjectId                                = GetInt64(new IntPtr(p + 0x018)); // 0x18 NIobjectId                  ( ModelPrimitiveType long long long Int64 )
            value.NIassemId                                 = GetInt64(new IntPtr(p + 0x020)); // 0x20 NIassemId                   ( ModelPrimitiveType long long long Int64 )
            value.NIprimitiveTypeEnum                       = (InternalPrimitiveTypeE)GetInt32(new IntPtr(p + 0x028)); // 0x28 NIprimitiveTypeEnum         ( ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32 )
            value.NItype                                    = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0x30 NItype                      ( ModelClassType Type Type Type Pointer )
            value.NIisSealed                                = GetBool(new IntPtr(p + 0x038)); // 0x38 NIisSealed                  ( ModelPrimitiveType bool bool bool Bool )
            value.NIisArray                                 = GetBool(new IntPtr(p + 0x039)); // 0x39 NIisArray                   ( ModelPrimitiveType bool bool bool Bool )
            value.NIisArrayItem                             = GetBool(new IntPtr(p + 0x03A)); // 0x3A NIisArrayItem               ( ModelPrimitiveType bool bool bool Bool )
            value.NItransmitTypeOnObject                    = GetBool(new IntPtr(p + 0x03B)); // 0x3B NItransmitTypeOnObject      ( ModelPrimitiveType bool bool bool Bool )
            value.NItransmitTypeOnMember                    = GetBool(new IntPtr(p + 0x03C)); // 0x3C NItransmitTypeOnMember      ( ModelPrimitiveType bool bool bool Bool )
            value.NIisParentTypeOnObject                    = GetBool(new IntPtr(p + 0x03D)); // 0x3D NIisParentTypeOnObject      ( ModelPrimitiveType bool bool bool Bool )
            value.NIarrayEnum                               = (InternalArrayTypeE)GetInt32(new IntPtr(p + 0x040)); // 0x40 NIarrayEnum                 ( ModelEnumType InternalArrayTypeE InternalArrayTypeE InternalArrayTypeE Int32 )
            value.NIsealedStatusChecked                     = GetBool(new IntPtr(p + 0x044)); // 0x44 NIsealedStatusChecked       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
