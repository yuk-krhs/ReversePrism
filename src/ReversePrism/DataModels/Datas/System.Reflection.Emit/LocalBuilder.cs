using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 028 Ilgen                                    00018658D430 ModelClassType ILGenerator ILGenerator ILGenerator Pointer
    // 030 StartOffset                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 EndOffset                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LocalBuilder : DataModel
    {
        public string                                   Name                                    { get; set; }
        public ILGenerator?                             Ilgen                                   { get; set; }
        public int                                      StartOffset                             { get; set; }
        public int                                      EndOffset                               { get; set; }

        public static LocalBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalBuilder() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 024666D42350 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Ilgen                                     = GetObject<ILGenerator>(new IntPtr(p + 0x028), ReversePrism.DataModels.ILGenerator.FromPointer); // 024666D42370 0x28 Ilgen                       ( 00018658D430 ModelClassType ILGenerator ILGenerator ILGenerator Pointer )
            value.StartOffset                               = GetInt32(new IntPtr(p + 0x030)); // 024666D42390 0x30 StartOffset                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndOffset                                 = GetInt32(new IntPtr(p + 0x034)); // 024666D423B0 0x34 EndOffset                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
