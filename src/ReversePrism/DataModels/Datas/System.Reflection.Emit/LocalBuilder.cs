using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 Ilgen                                    ModelClassType ILGenerator ILGenerator ILGenerator Pointer
    // 030 StartOffset                              ModelPrimitiveType int int int Int32
    // 034 EndOffset                                ModelPrimitiveType int int int Int32
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

            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.Ilgen                                     = GetObject<ILGenerator>(new IntPtr(p + 0x028), ReversePrism.DataModels.ILGenerator.FromPointer); // 0x28 Ilgen                       ( ModelClassType ILGenerator ILGenerator ILGenerator Pointer )
            value.StartOffset                               = GetInt32(new IntPtr(p + 0x030)); // 0x30 StartOffset                 ( ModelPrimitiveType int int int Int32 )
            value.EndOffset                                 = GetInt32(new IntPtr(p + 0x034)); // 0x34 EndOffset                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
