using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Elements                                 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 particles                                <object>[] IL2CPP_TYPE_SZARRAY
    // 028 IsRequired                               000186593A90 ModelClassType BitSet BitSet BitSet Pointer
    // 030 CountRequired                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AllElementsContentValidator
    {
        public Hashtable?                               Elements                                { get; set; }
        public BitSet?                                  IsRequired                              { get; set; }
        public int                                      CountRequired                           { get; set; }

        public static AllElementsContentValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AllElementsContentValidator();

            value.Elements                                  = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D74FF610 0x18 Elements                    ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IsRequired                                = GetObject<BitSet>(new IntPtr(p + 0x028), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FF650 0x28 IsRequired                  ( 000186593A90 ModelClassType BitSet BitSet BitSet Pointer )
            value.CountRequired                             = GetInt32(new IntPtr(p + 0x030)); // 0270D74FF670 0x30 CountRequired               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
