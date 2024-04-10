using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671BA0 ModelPrimitiveType string string string String
    // 018 RequireContentBody                       000186595210 ModelPrimitiveType bool bool bool Bool
    // 019 ContentBodyNotAllowed                    000186595210 ModelPrimitiveType bool bool bool Bool
    // 01A ConnectRequest                           000186595210 ModelPrimitiveType bool bool bool Bool
    // 01B ExpectNoContentResponse                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 000 NamedHeaders                             ListDictionary IL2CPP_TYPE_CLASS
    // 008 Get                                      KnownHttpVerb IL2CPP_TYPE_CLASS
    // 010 Connect                                  000186773C60 ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer
    // 018 Head                                     000186773C60 ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer
    // 020 Put                                      000186773C60 ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer
    // 028 Post                                     000186773C60 ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer
    // 030 MkCol                                    000186773C60 ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 024667A8CE38 0x10 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.RequireContentBody                        = GetBool(new IntPtr(p + 0x018)); // 024667A8CE58 0x18 RequireContentBody          ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ContentBodyNotAllowed                     = GetBool(new IntPtr(p + 0x019)); // 024667A8CE78 0x19 ContentBodyNotAllowed       ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ConnectRequest                            = GetBool(new IntPtr(p + 0x01A)); // 024667A8CE98 0x1A ConnectRequest              ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ExpectNoContentResponse                   = GetBool(new IntPtr(p + 0x01B)); // 024667A8CEB8 0x1B ExpectNoContentResponse     ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Connect                                   = GetObject<KnownHttpVerb>(new IntPtr(p + 0x010), ReversePrism.DataModels.KnownHttpVerb.FromPointer); // 024667A8CF18 0x10 Connect                     ( 000186773C60 ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer )
            value.Head                                      = GetObject<KnownHttpVerb>(new IntPtr(p + 0x018), ReversePrism.DataModels.KnownHttpVerb.FromPointer); // 024667A8CF38 0x18 Head                        ( 000186773C60 ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer )
            value.Put                                       = GetObject<KnownHttpVerb>(new IntPtr(p + 0x020), ReversePrism.DataModels.KnownHttpVerb.FromPointer); // 024667A8CF58 0x20 Put                         ( 000186773C60 ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer )
            value.Post                                      = GetObject<KnownHttpVerb>(new IntPtr(p + 0x028), ReversePrism.DataModels.KnownHttpVerb.FromPointer); // 024667A8CF78 0x28 Post                        ( 000186773C60 ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer )
            value.MkCol                                     = GetObject<KnownHttpVerb>(new IntPtr(p + 0x030), ReversePrism.DataModels.KnownHttpVerb.FromPointer); // 024667A8CF98 0x30 MkCol                       ( 000186773C60 ModelClassType KnownHttpVerb KnownHttpVerb KnownHttpVerb Pointer )

            return value;
        }
    }
}
