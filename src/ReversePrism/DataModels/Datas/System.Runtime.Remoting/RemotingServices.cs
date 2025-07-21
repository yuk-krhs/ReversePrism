using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 uri_hash                                 Hashtable IL2CPP_TYPE_CLASS
    // 008 _serializationFormatter                  BinaryFormatter IL2CPP_TYPE_CLASS
    // 010 DeserializationFormatter                 ModelClassType BinaryFormatter BinaryFormatter BinaryFormatter Pointer
    // 018 App_id                                   ModelPrimitiveType string string string String
    // 020 app_id_lock                              <object> IL2CPP_TYPE_OBJECT
    // 028 Next_id                                  ModelPrimitiveType int int int Int32
    // 030 FieldSetterMethod                        ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 038 FieldGetterMethod                        ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class RemotingServices : DataModel
    {
        public BinaryFormatter?                         DeserializationFormatter                { get; set; }
        public string                                   App_id                                  { get; set; }
        public int                                      Next_id                                 { get; set; }
        public MethodInfo?                              FieldSetterMethod                       { get; set; }
        public MethodInfo?                              FieldGetterMethod                       { get; set; }

        public static RemotingServices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemotingServices() { Pointer= p0 };

            value.DeserializationFormatter                  = GetObject<BinaryFormatter>(new IntPtr(p + 0x010), ReversePrism.DataModels.BinaryFormatter.FromPointer); // 0x10 DeserializationFormatter    ( ModelClassType BinaryFormatter BinaryFormatter BinaryFormatter Pointer )
            value.App_id                                    = GetString(new IntPtr(p + 0x018)); // 0x18 App_id                      ( ModelPrimitiveType string string string String )
            value.Next_id                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 Next_id                     ( ModelPrimitiveType int int int Int32 )
            value.FieldSetterMethod                         = GetObject<MethodInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x30 FieldSetterMethod           ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.FieldGetterMethod                         = GetObject<MethodInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x38 FieldGetterMethod           ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
