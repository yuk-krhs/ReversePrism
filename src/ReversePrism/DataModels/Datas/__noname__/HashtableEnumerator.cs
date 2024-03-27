using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Hashtable                                0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 Bucket                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Current                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 GetObjectRetType                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 _currentKey                              <object> IL2CPP_TYPE_OBJECT
    // 030 _currentValue                            <object> IL2CPP_TYPE_OBJECT
    public partial class HashtableEnumerator
    {
        public Hashtable?                               Hashtable                               { get; set; }
        public int                                      Bucket                                  { get; set; }
        public int                                      Version                                 { get; set; }
        public bool                                     Current                                 { get; set; }
        public int                                      GetObjectRetType                        { get; set; }

        public static HashtableEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HashtableEnumerator();

            value.Hashtable                                 = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 02700602FE80 0x10 Hashtable                   ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Bucket                                    = GetInt32(new IntPtr(p + 0x018)); // 02700602FEA0 0x18 Bucket                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 02700602FEC0 0x1C Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Current                                   = GetBool(new IntPtr(p + 0x020)); // 02700602FEE0 0x20 Current                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GetObjectRetType                          = GetInt32(new IntPtr(p + 0x024)); // 02700602FF00 0x24 GetObjectRetType            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
