using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Last                                     ModelPrimitiveType int int int Int32
    // 018 Names                                    ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 Wildcards                                ModelClassType Hashtable Hashtable Hashtable Pointer
    // 028 Particles                                ModelClassType ArrayList ArrayList ArrayList Pointer
    // 030 particleLast                             <object> IL2CPP_TYPE_OBJECT
    // 038 IsUpaEnforced                            ModelPrimitiveType bool bool bool Bool
    public partial class SymbolsDictionary : DataModel
    {
        public int                                      Last                                    { get; set; }
        public Hashtable?                               Names                                   { get; set; }
        public Hashtable?                               Wildcards                               { get; set; }
        public ArrayList?                               Particles                               { get; set; }
        public bool                                     IsUpaEnforced                           { get; set; }

        public static SymbolsDictionary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SymbolsDictionary() { Pointer= p0 };

            value.Last                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Last                        ( ModelPrimitiveType int int int Int32 )
            value.Names                                     = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0x18 Names                       ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Wildcards                                 = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0x20 Wildcards                   ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Particles                                 = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 0x28 Particles                   ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.IsUpaEnforced                             = GetBool(new IntPtr(p + 0x038)); // 0x38 IsUpaEnforced               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
