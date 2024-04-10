using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Last                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Names                                    0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 Wildcards                                0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 028 Particles                                00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 030 particleLast                             <object> IL2CPP_TYPE_OBJECT
    // 038 IsUpaEnforced                            000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.Last                                      = GetInt32(new IntPtr(p + 0x010)); // 02466755C158 0x10 Last                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Names                                     = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 02466755C178 0x18 Names                       ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Wildcards                                 = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 02466755C198 0x20 Wildcards                   ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Particles                                 = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 02466755C1B8 0x28 Particles                   ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.IsUpaEnforced                             = GetBool(new IntPtr(p + 0x038)); // 02466755C1F8 0x38 IsUpaEnforced               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
