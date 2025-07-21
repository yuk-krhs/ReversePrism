using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FEtypeFormat                             ModelEnumType FormatterTypeStyle FormatterTypeStyle FormatterTypeStyle Int32
    // 014 FEassemblyFormat                         ModelEnumType FormatterAssemblyStyle FormatterAssemblyStyle FormatterAssemblyStyle Int32
    // 018 FEsecurityLevel                          ModelEnumType TypeFilterLevel TypeFilterLevel TypeFilterLevel Int32
    // 01C FEserializerTypeEnum                     ModelEnumType InternalSerializerTypeE InternalSerializerTypeE InternalSerializerTypeE Int32
    public partial class InternalFE : DataModel
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
            var value   = new InternalFE() { Pointer= p0 };

            value.FEtypeFormat                              = (FormatterTypeStyle)GetInt32(new IntPtr(p + 0x010)); // 0x10 FEtypeFormat                ( ModelEnumType FormatterTypeStyle FormatterTypeStyle FormatterTypeStyle Int32 )
            value.FEassemblyFormat                          = (FormatterAssemblyStyle)GetInt32(new IntPtr(p + 0x014)); // 0x14 FEassemblyFormat            ( ModelEnumType FormatterAssemblyStyle FormatterAssemblyStyle FormatterAssemblyStyle Int32 )
            value.FEsecurityLevel                           = (TypeFilterLevel)GetInt32(new IntPtr(p + 0x018)); // 0x18 FEsecurityLevel             ( ModelEnumType TypeFilterLevel TypeFilterLevel TypeFilterLevel Int32 )
            value.FEserializerTypeEnum                      = (InternalSerializerTypeE)GetInt32(new IntPtr(p + 0x01C)); // 0x1C FEserializerTypeEnum        ( ModelEnumType InternalSerializerTypeE InternalSerializerTypeE InternalSerializerTypeE Int32 )

            return value;
        }
    }
}
