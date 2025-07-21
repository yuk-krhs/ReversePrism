using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Val                                      ModelPrimitiveType string string string String
    // 018 EntryPoint                               ModelPrimitiveType string string string String
    // 020 CharSet                                  ModelEnumType CharSet CharSet CharSet Int32
    // 024 SetLastError                             ModelPrimitiveType bool bool bool Bool
    // 025 ExactSpelling                            ModelPrimitiveType bool bool bool Bool
    // 026 PreserveSig                              ModelPrimitiveType bool bool bool Bool
    // 028 CallingConvention                        ModelEnumType CallingConvention CallingConvention CallingConvention Int32
    // 02C BestFitMapping                           ModelPrimitiveType bool bool bool Bool
    // 02D ThrowOnUnmappableChar                    ModelPrimitiveType bool bool bool Bool
    public partial class DllImportAttribute : DataModel
    {
        public string                                   Val                                     { get; set; }
        public string                                   EntryPoint                              { get; set; }
        public CharSet                                  CharSet                                 { get; set; }
        public bool                                     SetLastError                            { get; set; }
        public bool                                     ExactSpelling                           { get; set; }
        public bool                                     PreserveSig                             { get; set; }
        public CallingConvention                        CallingConvention                       { get; set; }
        public bool                                     BestFitMapping                          { get; set; }
        public bool                                     ThrowOnUnmappableChar                   { get; set; }

        public static DllImportAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DllImportAttribute() { Pointer= p0 };

            value.Val                                       = GetString(new IntPtr(p + 0x010)); // 0x10 Val                         ( ModelPrimitiveType string string string String )
            value.EntryPoint                                = GetString(new IntPtr(p + 0x018)); // 0x18 EntryPoint                  ( ModelPrimitiveType string string string String )
            value.CharSet                                   = (CharSet)GetInt32(new IntPtr(p + 0x020)); // 0x20 CharSet                     ( ModelEnumType CharSet CharSet CharSet Int32 )
            value.SetLastError                              = GetBool(new IntPtr(p + 0x024)); // 0x24 SetLastError                ( ModelPrimitiveType bool bool bool Bool )
            value.ExactSpelling                             = GetBool(new IntPtr(p + 0x025)); // 0x25 ExactSpelling               ( ModelPrimitiveType bool bool bool Bool )
            value.PreserveSig                               = GetBool(new IntPtr(p + 0x026)); // 0x26 PreserveSig                 ( ModelPrimitiveType bool bool bool Bool )
            value.CallingConvention                         = (CallingConvention)GetInt32(new IntPtr(p + 0x028)); // 0x28 CallingConvention           ( ModelEnumType CallingConvention CallingConvention CallingConvention Int32 )
            value.BestFitMapping                            = GetBool(new IntPtr(p + 0x02C)); // 0x2C BestFitMapping              ( ModelPrimitiveType bool bool bool Bool )
            value.ThrowOnUnmappableChar                     = GetBool(new IntPtr(p + 0x02D)); // 0x2D ThrowOnUnmappableChar       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
