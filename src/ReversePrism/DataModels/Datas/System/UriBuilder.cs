using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Changed                                  ModelPrimitiveType bool bool bool Bool
    // 018 Fragment                                 ModelPrimitiveType string string string String
    // 020 Host                                     ModelPrimitiveType string string string String
    // 028 Password                                 ModelPrimitiveType string string string String
    // 030 Path                                     ModelPrimitiveType string string string String
    // 038 Port                                     ModelPrimitiveType int int int Int32
    // 040 Query                                    ModelPrimitiveType string string string String
    // 048 Scheme                                   ModelPrimitiveType string string string String
    // 050 SchemeDelimiter                          ModelPrimitiveType string string string String
    // 058 Uri                                      ModelClassType Uri Uri Uri Pointer
    // 060 Username                                 ModelPrimitiveType string string string String
    public partial class UriBuilder : DataModel
    {
        public bool                                     Changed                                 { get; set; }
        public string                                   Fragment                                { get; set; }
        public string                                   Host                                    { get; set; }
        public string                                   Password                                { get; set; }
        public string                                   Path                                    { get; set; }
        public int                                      Port                                    { get; set; }
        public string                                   Query                                   { get; set; }
        public string                                   Scheme                                  { get; set; }
        public string                                   SchemeDelimiter                         { get; set; }
        public Uri?                                     Uri                                     { get; set; }
        public string                                   Username                                { get; set; }

        public static UriBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UriBuilder() { Pointer= p0 };

            value.Changed                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 Changed                     ( ModelPrimitiveType bool bool bool Bool )
            value.Fragment                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Fragment                    ( ModelPrimitiveType string string string String )
            value.Host                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Host                        ( ModelPrimitiveType string string string String )
            value.Password                                  = GetString(new IntPtr(p + 0x028)); // 0x28 Password                    ( ModelPrimitiveType string string string String )
            value.Path                                      = GetString(new IntPtr(p + 0x030)); // 0x30 Path                        ( ModelPrimitiveType string string string String )
            value.Port                                      = GetInt32(new IntPtr(p + 0x038)); // 0x38 Port                        ( ModelPrimitiveType int int int Int32 )
            value.Query                                     = GetString(new IntPtr(p + 0x040)); // 0x40 Query                       ( ModelPrimitiveType string string string String )
            value.Scheme                                    = GetString(new IntPtr(p + 0x048)); // 0x48 Scheme                      ( ModelPrimitiveType string string string String )
            value.SchemeDelimiter                           = GetString(new IntPtr(p + 0x050)); // 0x50 SchemeDelimiter             ( ModelPrimitiveType string string string String )
            value.Uri                                       = GetObject<Uri>(new IntPtr(p + 0x058), ReversePrism.DataModels.Uri.FromPointer); // 0x58 Uri                         ( ModelClassType Uri Uri Uri Pointer )
            value.Username                                  = GetString(new IntPtr(p + 0x060)); // 0x60 Username                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
