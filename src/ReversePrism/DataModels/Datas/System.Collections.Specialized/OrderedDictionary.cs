using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectsArray                             00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 018 ObjectsTable                             0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 InitialCapacity                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Comparer                                 000186762030 ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer
    // 030 ReadOnly                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    // 040 SiInfo                                   0001866636F0 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    public partial class OrderedDictionary
    {
        public ArrayList?                               ObjectsArray                            { get; set; }
        public Hashtable?                               ObjectsTable                            { get; set; }
        public int                                      InitialCapacity                         { get; set; }
        public IEqualityComparer?                       Comparer                                { get; set; }
        public bool                                     ReadOnly                                { get; set; }
        public SerializationInfo?                       SiInfo                                  { get; set; }

        public static OrderedDictionary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OrderedDictionary();

            value.ObjectsArray                              = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 02700602D9F0 0x10 ObjectsArray                ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.ObjectsTable                              = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 02700602DA10 0x18 ObjectsTable                ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.InitialCapacity                           = GetInt32(new IntPtr(p + 0x020)); // 02700602DA30 0x20 InitialCapacity             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Comparer                                  = GetObject<IEqualityComparer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IEqualityComparer.FromPointer); // 02700602DA50 0x28 Comparer                    ( 000186762030 ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer )
            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x030)); // 02700602DA70 0x30 ReadOnly                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SiInfo                                    = GetObject<SerializationInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.SerializationInfo.FromPointer); // 02700602DAB0 0x40 SiInfo                      ( 0001866636F0 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )

            return value;
        }
    }
}
