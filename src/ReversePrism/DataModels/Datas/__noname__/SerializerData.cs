using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReaderMethod                             0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 WriterType                               000186692F60 ModelClassType Type Type Type Pointer
    // 020 WriterMethod                             0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 028 Implementation                           0001865C8A40 ModelClassType XmlSerializerImplementation XmlSerializerImplementation XmlSerializerImplementation Pointer
    public partial class SerializerData : DataModel
    {
        public MethodInfo?                              ReaderMethod                            { get; set; }
        public Type?                                    WriterType                              { get; set; }
        public MethodInfo?                              WriterMethod                            { get; set; }
        public XmlSerializerImplementation?             Implementation                          { get; set; }

        public static SerializerData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializerData() { Pointer= p0 };

            value.ReaderMethod                              = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 024667539698 0x10 ReaderMethod                ( 0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriterType                                = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0246675396B8 0x18 WriterType                  ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.WriterMethod                              = GetObject<MethodInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.MethodInfo.FromPointer); // 0246675396D8 0x20 WriterMethod                ( 0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Implementation                            = GetObject<XmlSerializerImplementation>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSerializerImplementation.FromPointer); // 0246675396F8 0x28 Implementation              ( 0001865C8A40 ModelClassType XmlSerializerImplementation XmlSerializerImplementation XmlSerializerImplementation Pointer )

            return value;
        }
    }
}
