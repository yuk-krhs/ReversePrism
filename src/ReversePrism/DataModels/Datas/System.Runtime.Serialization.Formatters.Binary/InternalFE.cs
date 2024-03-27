using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FEtypeFormat                             0001865B8CB0 ModelEnumType FormatterTypeStyle FormatterTypeStyle FormatterTypeStyle Int32
    // 014 FEassemblyFormat                         0001865B7E20 ModelEnumType FormatterAssemblyStyle FormatterAssemblyStyle FormatterAssemblyStyle Int32
    // 018 FEsecurityLevel                          0001866D5CF0 ModelEnumType TypeFilterLevel TypeFilterLevel TypeFilterLevel Int32
    // 01C FEserializerTypeEnum                     00018671EC10 ModelEnumType InternalSerializerTypeE InternalSerializerTypeE InternalSerializerTypeE Int32
    public partial class InternalFE
    {
        public FormatterTypeStyle                       FEtypeFormat                            { get; set; }
        public FormatterAssemblyStyle                   FEassemblyFormat                        { get; set; }
        public TypeFilterLevel                          FEsecurityLevel                         { get; set; }
        public InternalSerializerTypeE                  FEserializerTypeEnum                    { get; set; }

        public static InternalFE? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternalFE();

            value.FEtypeFormat                              = (FormatterTypeStyle)GetInt32(new IntPtr(p + 0x010)); // 0270D6C54A80 0x10 FEtypeFormat                ( 0001865B8CB0 ModelEnumType FormatterTypeStyle FormatterTypeStyle FormatterTypeStyle Int32 )
            value.FEassemblyFormat                          = (FormatterAssemblyStyle)GetInt32(new IntPtr(p + 0x014)); // 0270D6C54AA0 0x14 FEassemblyFormat            ( 0001865B7E20 ModelEnumType FormatterAssemblyStyle FormatterAssemblyStyle FormatterAssemblyStyle Int32 )
            value.FEsecurityLevel                           = (TypeFilterLevel)GetInt32(new IntPtr(p + 0x018)); // 0270D6C54AC0 0x18 FEsecurityLevel             ( 0001866D5CF0 ModelEnumType TypeFilterLevel TypeFilterLevel TypeFilterLevel Int32 )
            value.FEserializerTypeEnum                      = (InternalSerializerTypeE)GetInt32(new IntPtr(p + 0x01C)); // 0270D6C54AE0 0x1C FEserializerTypeEnum        ( 00018671EC10 ModelEnumType InternalSerializerTypeE InternalSerializerTypeE InternalSerializerTypeE Int32 )

            return value;
        }
    }
}
