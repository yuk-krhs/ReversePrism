using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 RequireContentBody                       ModelPrimitiveType bool bool bool Bool
    // 019 ContentBodyNotAllowed                    ModelPrimitiveType bool bool bool Bool
    // 01A ConnectRequest                           ModelPrimitiveType bool bool bool Bool
    // 01B ExpectNoContentResponse                  ModelPrimitiveType bool bool bool Bool
    // 000 NamedHeaders                             ListDictionary IL2CPP_TYPE_CLASS
    // 008 Get                                      KnownHttpVerb IL2CPP_TYPE_CLASS
    // 010 Connect                                  ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer
    // 018 Head                                     ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer
    // 020 Put                                      ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer
    // 028 Post                                     ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer
    // 030 MkCol                                    ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer
    public partial class KnownHttpVerb : DataModel
    {
        public string                                   Name                                    { get; set; }
        public bool                                     RequireContentBody                      { get; set; }
        public bool                                     ContentBodyNotAllowed                   { get; set; }
        public bool                                     ConnectRequest                          { get; set; }
        public bool                                     ExpectNoContentResponse                 { get; set; }
        public KnownHttpVerb?                           Connect                                 { get; set; }
        public KnownHttpVerb?                           Head                                    { get; set; }
        public KnownHttpVerb?                           Put                                     { get; set; }
        public KnownHttpVerb?                           Post                                    { get; set; }
        public KnownHttpVerb?                           MkCol                                   { get; set; }

        public static KnownHttpVerb? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KnownHttpVerb() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.RequireContentBody                        = GetBool(new IntPtr(p + 0x018)); // 0x18 RequireContentBody          ( ModelPrimitiveType bool bool bool Bool )
            value.ContentBodyNotAllowed                     = GetBool(new IntPtr(p + 0x019)); // 0x19 ContentBodyNotAllowed       ( ModelPrimitiveType bool bool bool Bool )
            value.ConnectRequest                            = GetBool(new IntPtr(p + 0x01A)); // 0x1A ConnectRequest              ( ModelPrimitiveType bool bool bool Bool )
            value.ExpectNoContentResponse                   = GetBool(new IntPtr(p + 0x01B)); // 0x1B ExpectNoContentResponse     ( ModelPrimitiveType bool bool bool Bool )
            value.Connect                                   = GetObject<KnownHttpVerb>(new IntPtr(p + 0x010), ReversePrism.DataModels.KnownHttpVerb.FromPointer); // 0x10 Connect                     ( ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer )
            value.Head                                      = GetObject<KnownHttpVerb>(new IntPtr(p + 0x018), ReversePrism.DataModels.KnownHttpVerb.FromPointer); // 0x18 Head                        ( ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer )
            value.Put                                       = GetObject<KnownHttpVerb>(new IntPtr(p + 0x020), ReversePrism.DataModels.KnownHttpVerb.FromPointer); // 0x20 Put                         ( ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer )
            value.Post                                      = GetObject<KnownHttpVerb>(new IntPtr(p + 0x028), ReversePrism.DataModels.KnownHttpVerb.FromPointer); // 0x28 Post                        ( ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer )
            value.MkCol                                     = GetObject<KnownHttpVerb>(new IntPtr(p + 0x030), ReversePrism.DataModels.KnownHttpVerb.FromPointer); // 0x30 MkCol                       ( ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer )

            return value;
        }
    }
}
